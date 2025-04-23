FROM --platform=$BUILDPLATFORM weihanli/aspire-dashboard-base
ENV ASPNETCORE_HTTP_PORTS=18888 \
    DOTNET_DASHBOARD_OTLP_ENDPOINT_URL=http://+:18889 \
    DOTNET_DASHBOARD_OTLP_HTTP_ENDPOINT_URL=http://+:18890
ENV DOTNET_DASHBOARD_UNSECURED_ALLOW_ANONYMOUS="true"
LABEL org.opencontainers.image.authors="WeihanLi"
LABEL org.opencontainers.image.source="https://github.com/WeihanLi/aspire"
LABEL org.opencontainers.image.title="aspire-dashboard"
