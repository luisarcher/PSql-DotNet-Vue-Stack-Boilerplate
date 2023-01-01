echo "Rebuilding docker image..."
docker build . -t frontend:1.0 --no-cache
pause
