FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/bichtram.Web.Mvc/bichtram.Web.Mvc.csproj", "src/bichtram.Web.Mvc/"]
COPY ["src/bichtram.Web.Core/bichtram.Web.Core.csproj", "src/bichtram.Web.Core/"]
COPY ["src/bichtram.Application/bichtram.Application.csproj", "src/bichtram.Application/"]
COPY ["src/bichtram.Core/bichtram.Core.csproj", "src/bichtram.Core/"]
COPY ["src/bichtram.EntityFrameworkCore/bichtram.EntityFrameworkCore.csproj", "src/bichtram.EntityFrameworkCore/"]
WORKDIR "/src/src/bichtram.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/bichtram.Web.Mvc", "src/bichtram.Web.Mvc"]
COPY ["src/bichtram.Web.Core", "src/bichtram.Web.Core"]
COPY ["src/bichtram.Application", "src/bichtram.Application"]
COPY ["src/bichtram.Core", "src/bichtram.Core"]
COPY ["src/bichtram.EntityFrameworkCore", "src/bichtram.EntityFrameworkCore"]
WORKDIR "/src/src/bichtram.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "bichtram.Web.Mvc.dll"]
