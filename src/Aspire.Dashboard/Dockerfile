FROM --platform=$BUILDPLATFORM weihanli/aspire-dashboard-base

# Add labels
LABEL org.opencontainers.image.authors="WeihanLi"
LABEL org.opencontainers.image.source="https://github.com/WeihanLi/aspire"
LABEL org.opencontainers.image.title="aspire-dashboard"

# Configure the necessary environment variables to align with the official container image
# https://github.com/dotnet/dotnet-docker/tree/main/src/aspire-dashboard/9.1/azurelinux-distroless/amd64
ENV ASPNETCORE_HTTP_PORTS=18888 \
    ASPNETCORE_URLS=http://+:18888 \
    DOTNET_DASHBOARD_OTLP_ENDPOINT_URL=http://+:18889 \
    DOTNET_DASHBOARD_OTLP_HTTP_ENDPOINT_URL=http://+:18890

# Allow anonymous by default
ENV DOTNET_DASHBOARD_UNSECURED_ALLOW_ANONYMOUS="true"
