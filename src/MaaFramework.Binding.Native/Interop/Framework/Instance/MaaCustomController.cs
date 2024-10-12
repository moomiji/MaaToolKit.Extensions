﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable CS1573 // 参数在 XML 注释中没有匹配的 param 标记
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释

using MaaFramework.Binding.Buffers;
using MaaFramework.Binding.Custom;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MaaFramework.Binding.Interop.Native;

/// <summary>
///     A static class providing extension methods for the converter of <see cref="IMaaCustomController"/>.
/// </summary>
[CustomMarshaller(typeof(IMaaCustomController), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))]
public static class MaaCustomControllerMarshaller
{
    private static ConcurrentDictionary<IMaaCustomController, ManagedToUnmanagedIn> Instances { get; } = [];

    /// <inheritdoc cref="GCHandle.Free"/>
    public static void Free(IMaaCustomController managed)
    {
        if (Instances.TryGetValue(managed, out var value))
        {
            ManagedToUnmanagedIn.Free(value);
        }
    }

    public struct ManagedToUnmanagedIn
    {
        private IMaaCustomController _managed;
        private Delegates _delegates;
        private GCHandle _handle;

        public void FromManaged(IMaaCustomController managed)
        {
            _managed = managed;
            _delegates = new Delegates(managed);
        }

        public MaaCustomControllerCallbacksHandle ToUnmanaged()
        {
            _handle = GCHandle.Alloc(new Unmanaged(_delegates), GCHandleType.Pinned);

            var value = Instances.GetOrAdd(_managed, this);
            Interlocked.Increment(ref value._delegates.Times);
            if (value._handle != _handle)
                _handle.Free();

            return value._handle.AddrOfPinnedObject();
        }

        /// <inheritdoc cref="GCHandle.Free"/>
        public static void Free(ManagedToUnmanagedIn value)
        {
            if (Interlocked.Decrement(ref value._delegates.Times) == 0 && Instances.TryRemove(value._managed, out _))
            {
                value._handle.Free();
            }
        }
    }

    private sealed class Delegates(IMaaCustomController managed)
    {
        public int Times = 0;
        public ConnectDelegate Connect = (nint transArg) => managed.Connect();
        public RequestUuidDelegate RequestUuid = (nint transArg, MaaStringBufferHandle buffer) => managed.RequestUuid(new MaaStringBuffer(buffer));
        public StartAppDelegate StartApp = (string intent, nint transArg) => managed.StartApp(intent);
        public StopAppDelegate StopApp = (string intent, nint transArg) => managed.StopApp(intent);
        public ScreencapDelegate Screencap = (nint transArg, MaaImageBufferHandle buffer) => managed.Screencap(new MaaImageBuffer(buffer));
        public ClickDelegate Click = (int x, int y, nint transArg) => managed.Click(x, y);
        public SwipeDelegate Swipe = (int x1, int y1, int x2, int y2, int duration, nint transArg) => managed.Swipe(x1, y1, x2, y2, duration);
        public TouchDownDelegate TouchDown = (int contact, int x, int y, int pressure, nint transArg) => managed.TouchDown(contact, x, y, pressure);
        public TouchMoveDelegate TouchMove = (int contact, int x, int y, int pressure, nint transArg) => managed.TouchMove(contact, x, y, pressure);
        public TouchUpDelegate TouchUp = (int contact, nint transArg) => managed.TouchUp(contact);
        public PressKeyDelegate PressKey = (int keycode, nint transArg) => managed.PressKey(keycode);
        public InputTextDelegate InputText = (string text, nint transArg) => managed.InputText(text);
    };

    /// <summary>
    ///     The custom controller API.
    /// </summary>
    /// <remarks>
    ///     <para>To create a custom controller, you need to implement this API.</para>
    ///     <para>You do not have to implement all the functions in this API. Instead, just implement the functions you need. Do note that if an unimplemented function is called, the framework will likely crash.</para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    private sealed class Unmanaged(Delegates delegates)
    {
        public nint ConnectFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.Connect);
        public nint RequestUuidFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.RequestUuid);
        public nint StartAppFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.StartApp);
        public nint StopAppFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.StopApp);
        public nint ScreencapFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.Screencap);
        public nint ClickFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.Click);
        public nint SwipeFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.Swipe);
        public nint TouchDownFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.TouchDown);
        public nint TouchMoveFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.TouchMove);
        public nint TouchUpFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.TouchUp);
        public nint PressKeyFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.PressKey);
        public nint InputTextFunctionPointer = Marshal.GetFunctionPointerForDelegate(delegates.InputText);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool ConnectDelegate(nint transArg);

    /// <summary>
    ///     Write result to buffer.
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool RequestUuidDelegate(nint transArg, MaaStringBufferHandle buffer);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool StartAppDelegate([MarshalAs(UnmanagedType.LPUTF8Str)] string intent, nint transArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool StopAppDelegate([MarshalAs(UnmanagedType.LPUTF8Str)] string intent, nint transArg);

    /// <summary>
    ///     Write result to buffer.
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool ScreencapDelegate(nint transArg, MaaImageBufferHandle buffer);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool ClickDelegate(int x, int y, nint transArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool SwipeDelegate(int x1, int y1, int x2, int y2, int duration, nint transArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool TouchDownDelegate(int contact, int x, int y, int pressure, nint transArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool TouchMoveDelegate(int contact, int x, int y, int pressure, nint transArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool TouchUpDelegate(int contact, nint transArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool PressKeyDelegate(int keycode, nint transArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private delegate bool InputTextDelegate([MarshalAs(UnmanagedType.LPUTF8Str)] string text, nint transArg);
}
