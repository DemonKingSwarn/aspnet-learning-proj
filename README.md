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
ln -s /etc/nginx/site-available/default /etc/nginx/sites-enabled/nginx
```
