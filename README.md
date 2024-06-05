# ASP.NET Learning Project

## Nginx Configuration

- `/etc/nginx/sites-available/default`

```conf
server {
	listen 80;

	server_name localhost;

	location / {
		proxy_pass	http://127.0.0.1:5000;
		proxy_http_version	1.1;
		proxy_set_header	Upgrade $http_upgrade;
		proxy_set_header 	Connection keep-alive;
		proxy_set_header	Host $host;
		proxy_cache_bypass	$http_upgrade;
		proxy_set_header	X-Forwarded-For $proxy_add_x_forwarded_for;
		proxy_set_header	X-Forwarded-Proto $scheme;
	}
}
```

```sh
ln -s /etc/nginx/site-available/default /etc/nginx/sites-enabled/default
```

## Dotnet and ASP.NET Installation and Project Setup

**Installation**

```sh
paru -S dotnet-runtime dotnet-sdk aspnet-runtime
```

**Setup**

- List the available dotnet templates if want for another project

```sh
dotnet new list
```

- Create a directory and cd into it and select ASP.NET mvc template

```sh
mkdir aspnet-proj && cd aspnet-proj
dotnet new mvc
```
