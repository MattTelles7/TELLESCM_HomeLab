# Home Lab

A starting point for a home-lab website built with ASP.NET Core MVC. It covers servers, game servers, and media servers.

## Run locally

Install the .NET 8 SDK, then run `dotnet run` from this directory. Open the URL printed in the terminal.

## Host on Linux

Install Git, Docker, and the Docker Compose plugin. From the directory where you want to keep the project, run:

```sh
git clone https://github.com/MattTelles7/TELLESCM_HomeLab.git && cd TELLESCM_HomeLab && docker compose up -d --build
```

Open `http://localhost` on the host or use the host's IP address from another device. Port 80 must be available, and your user must have permission to run Docker. Your firewall may need to allow incoming traffic. This serves HTTP; HTTPS and public internet access require additional setup.

To update after pulling changes, run `git pull && docker compose up -d --build`. To stop the site, run `docker compose down`.
