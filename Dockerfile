FROM mcr.microsoft.com/dotnet/aspnet:5.0

COPY bin/Release/net5.0/publish/ App/
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
WORKDIR /App
ENTRYPOINT ["dotnet", "AspNetCore5Microservices.dll"]
