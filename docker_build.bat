echo "Rebuilding docker image..."
docker build . -t dotnetapp:1.0 --no-cache
pause
