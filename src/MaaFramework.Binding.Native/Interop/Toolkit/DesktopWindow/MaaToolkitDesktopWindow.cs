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

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MaaFramework.Binding.Interop.Native;

public static partial class MaaToolkit
{
    [LibraryImport("MaaToolkit", StringMarshalling = StringMarshalling.Utf8)]
    public static partial MaaToolkitDesktopWindowListHandle MaaToolkitDesktopWindowListCreate();

    [LibraryImport("MaaToolkit", StringMarshalling = StringMarshalling.Utf8)]
    public static partial void MaaToolkitDesktopWindowListDestroy(MaaToolkitDesktopWindowListHandle handle);

    [LibraryImport("MaaToolkit", StringMarshalling = StringMarshalling.Utf8)]
    [return: MarshalAs(UnmanagedType.U1)]
    public static partial bool MaaToolkitDesktopWindowFindAll(MaaToolkitDesktopWindowListHandle buffer);

    [LibraryImport("MaaToolkit", StringMarshalling = StringMarshalling.Utf8)]
    public static partial MaaSize MaaToolkitDesktopWindowListSize(MaaToolkitDesktopWindowListHandle list);

    [LibraryImport("MaaToolkit", StringMarshalling = StringMarshalling.Utf8)]
    public static partial MaaToolkitDesktopWindowHandle MaaToolkitDesktopWindowListAt(MaaToolkitDesktopWindowListHandle list, MaaSize index);

    [LibraryImport("MaaToolkit", StringMarshalling = StringMarshalling.Utf8)]
    public static partial nint MaaToolkitDesktopWindowGetHandle(MaaToolkitDesktopWindowHandle window);

    [LibraryImport("MaaToolkit", StringMarshalling = StringMarshalling.Utf8)]
    [return: MarshalUsing(typeof(MaaStringViewMarshaller))]
    public static partial string MaaToolkitDesktopWindowGetClassName(MaaToolkitDesktopWindowHandle window);

    [LibraryImport("MaaToolkit", StringMarshalling = StringMarshalling.Utf8)]
    [return: MarshalUsing(typeof(MaaStringViewMarshaller))]
    public static partial string MaaToolkitDesktopWindowGetWindowName(MaaToolkitDesktopWindowHandle window);
}
