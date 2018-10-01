# See https://aka.ms/containerimagehelp for information on how to use Windows Server 1709 containers with Service Fabric.
# FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709
FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016
ARG source
WORKDIR /app
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "ServerTime.dll"]
