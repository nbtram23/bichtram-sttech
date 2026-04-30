FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/bichtram.Web.Host/bichtram.Web.Host.csproj", "src/bichtram.Web.Host/"]
COPY ["src/bichtram.Web.Core/bichtram.Web.Core.csproj", "src/bichtram.Web.Core/"]
COPY ["src/bichtram.Application/bichtram.Application.csproj", "src/bichtram.Application/"]
COPY ["src/bichtram.Core/bichtram.Core.csproj", "src/bichtram.Core/"]
COPY ["src/bichtram.EntityFrameworkCore/bichtram.EntityFrameworkCore.csproj", "src/bichtram.EntityFrameworkCore/"]
WORKDIR "/src/src/bichtram.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/bichtram.Web.Host", "src/bichtram.Web.Host"]
COPY ["src/bichtram.Web.Core", "src/bichtram.Web.Core"]
COPY ["src/bichtram.Application", "src/bichtram.Application"]
COPY ["src/bichtram.Core", "src/bichtram.Core"]
COPY ["src/bichtram.EntityFrameworkCore", "src/bichtram.EntityFrameworkCore"]
WORKDIR "/src/src/bichtram.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "bichtram.Web.Host.dll"]
