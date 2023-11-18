// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aspire.Hosting.Utils;

internal static class ContainerUtil
{
    private const string PreferredContainerTypeEnvName = "DOTNET_ASPIRE_CONTAINER_TYPE";
    private const string DockerContainerCommandName = "docker";
    private const string PodmanContainerCommandName = "podman";

    public static readonly string ContainerExecCommandName;
    public static readonly string ContainerExecCommandFullPath;

    static ContainerUtil()
    {
        (ContainerExecCommandName, ContainerExecCommandFullPath) = GetContainerExecCommandInfo();
    }

    private static (string commandName, string fullPath) GetContainerExecCommandInfo()
    {
        var preferredContainerType = Environment.GetEnvironmentVariable(PreferredContainerTypeEnvName);
        if (!string.IsNullOrEmpty(preferredContainerType))
        {
            return (preferredContainerType, FileUtil.FindFullPathFromPath(preferredContainerType));
        }

        // prefer docker to keep the same behavior
        var dockerFullPath = FileUtil.FindFullPathFromPath(DockerContainerCommandName);
        if (!string.IsNullOrEmpty(dockerFullPath) && !string.IsNullOrEmpty(Path.GetDirectoryName(dockerFullPath)))
        {
            return (DockerContainerCommandName, dockerFullPath);
        }

        return (PodmanContainerCommandName, FileUtil.FindFullPathFromPath(PodmanContainerCommandName));
    }
}
