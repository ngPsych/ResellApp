FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS build
WORKDIR /src
COPY ["ResellAPI/ResellAPI.csproj", "./ResellAPI/"]
RUN dotnet restore "ResellAPI/ResellAPI.csproj"
COPY ResellAPI/ ./ResellAPI/
WORKDIR "src/ReselAPI"
RUN dotnet build "ResellAPI.csproj" -c Release -o /app/build

# publishing the app
FROM build AS publish
RUN dotnet publish "ResellAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ResellAPI.dll"]