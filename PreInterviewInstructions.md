# Instructions
## Docker Setup Instructions

### 1. Install Docker Desktop
- Go to the official Docker Desktop download page: https://www.docker.com/products/docker-desktop/
- Download the installer for Windows.
- Run the installer and follow the on-screen instructions.
- After installation, launch Docker Desktop and ensure it is running.

### 2. Docker Compose
- Docker Compose is included with Docker Desktop by default. No separate installation is needed.

### 3. Verify Installation
- To check Docker installation:
	```powershell
	docker --version
	```
- To check Docker Compose installation:
	```powershell
	docker compose version
	```

### 4. Pull Required Images
Open PowerShell and run the following commands:

```powershell
docker pull mcr.microsoft.com/dotnet/sdk:8.0
docker pull node:20-alpine
```
You are now ready to use Docker and Docker Compose with the required images.
