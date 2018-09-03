rm -rf /root/simate/ && git clone https://github.com/abcsxl/simate.git
cd simate/simate && dotnet publish --configuration Release && cd /root/
rm -rf /var/aspnetcore/simate/ && cp -rf /root/simate/simate/bin/Release/netcoreapp2.1/publish/ /var/aspnetcore/ && mv /var/aspnetcore/publish/ /var/aspnetcore/simate
chmod 774 /var/aspnetcore/simate/app.db
chown apache /var/aspnetcore/simate/app.db && chown apache /var/aspnetcore/simate
systemctl restart kestrel-simate.service