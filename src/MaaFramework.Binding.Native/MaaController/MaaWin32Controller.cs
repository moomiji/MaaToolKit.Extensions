﻿using static MaaFramework.Binding.Interop.Native.MaaController;

namespace MaaFramework.Binding;

/// <summary>
///     A wrapper class providing a reference implementation for <see cref="MaaWin32ControllerCreate"/>.
/// </summary>
public class MaaWin32Controller : MaaController
{
    /// <summary>
    ///     Creates a <see cref="MaaWin32Controller"/> instance.
    /// </summary>
    /// <param name="hWnd">The window handle.</param>
    /// <param name="types">The Win32ControllerTypes.</param>
    /// <remarks>
    ///     Wrapper of <see cref="MaaWin32ControllerCreate"/>.
    /// </remarks>
    public MaaWin32Controller(nint hWnd, Win32ControllerTypes types)
    {
        var handle = MaaWin32ControllerCreate(hWnd, (MaaWin32ControllerType)types, MaaApiCallback, nint.Zero);
        SetHandle(handle, needReleased: true);
    }
}