#!/usr/bin/env bash
set -ie
(cd say && mono paket.exe install && fsharpi app.fsx &)
lt --port 8001
