#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained by merging endpoint snippets from
# https://developers.gamma.app/generations/*.md and
# https://developers.gamma.app/workspace/*.md
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Gamma \
  --clientClassName GammaClient \
  --targetFramework net10.0 \
  --security-scheme ApiKey:Header:X-API-KEY \
  --output Generated \
  --exclude-deprecated-operations

rm -rf ../../cli/Gamma.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Gamma.CLI \
  --sdk-project ../../libs/Gamma/Gamma.csproj \
  --targetFramework net10.0 \
  --namespace Gamma \
  --clientClassName GammaClient \
  --package-id Gamma.CLI \
  --tool-command-name gamma \
  --user-secrets-id Gamma.CLI \
  --api-key-env-var GAMMA_API_KEY \
  --base-url-env-var GAMMA_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-KEY
