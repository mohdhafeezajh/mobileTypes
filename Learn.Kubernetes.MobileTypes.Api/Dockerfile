#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY Learn.Kubernetes.MobileTypes.Api/Learn.Kubernetes.MobileTypes.Api.csproj Learn.Kubernetes.MobileTypes.Api/
COPY Learn.Kubernetes.MobileTypes.Service/Learn.Kubernetes.MobileTypes.Service.csproj Learn.Kubernetes.MobileTypes.Service/
COPY Learn.Kubernetes.MobileTypes.Persistence/Learn.Kubernetes.MobileTypes.Persistence.csproj Learn.Kubernetes.MobileTypes.Persistence/
RUN dotnet restore "Learn.Kubernetes.MobileTypes.Api/Learn.Kubernetes.MobileTypes.Api.csproj"
COPY . .
WORKDIR "/src/Learn.Kubernetes.MobileTypes.Api"
RUN dotnet build "Learn.Kubernetes.MobileTypes.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Learn.Kubernetes.MobileTypes.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Learn.Kubernetes.MobileTypes.Api.dll"]
