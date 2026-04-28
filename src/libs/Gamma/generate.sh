#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained by merging endpoint snippets from
# https://developers.gamma.app/generations/*.md and
# https://developers.gamma.app/workspace/*.md

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Gamma \
  --clientClassName GammaClient \
  --targetFramework net10.0 \
  --security-scheme ApiKey:Header:X-API-KEY \
  --output Generated \
  --exclude-deprecated-operations
