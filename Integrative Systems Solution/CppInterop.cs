using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.RightsManagement;

public static class CppInterop
{
    const string CppDllPath = "Integrative Systems Backend.dll"; 

    //Operation Functions
    [DllImport(CppDllPath)]
    public static extern IntPtr ConstructOperation();
    [DllImport(CppDllPath)]
    public static extern void SetOperationUserName(IntPtr o, string n);
    [DllImport(CppDllPath)]
    public static extern void SetOperationNote(IntPtr o, string n);
    [DllImport(CppDllPath)]
    public static extern void SetOperationLoadOrBalance(IntPtr o, char x);
    [DllImport(CppDllPath)]
    public static extern void SetOperationManifestPath(IntPtr o, string m);
    [DllImport(CppDllPath)]
    public static extern string GetOperationManifestPath(IntPtr o);
    [DllImport(CppDllPath)]
    public static extern void GetOperationContainers(IntPtr o, List<IntPtr> c);
    [DllImport(CppDllPath)]
    public static extern void GetOperationMoves(IntPtr o, List<IntPtr> m);
    [DllImport(CppDllPath)]
    public static extern void SetOperationUnLoad(IntPtr o, List<IntPtr> c);
    [DllImport(CppDllPath)]
    public static extern void SetOperationLoad(IntPtr o, List<IntPtr> c);
    [DllImport(CppDllPath)]
    public static extern void OperationMoveComplete(IntPtr o, int a);
    [DllImport(CppDllPath)]
    public static extern void OperationReset(IntPtr o);

    //Move Functions
    [DllImport(CppDllPath)]
    public static extern IntPtr ConstructMove();
    [DllImport(CppDllPath)]
    public static extern IntPtr GetMoveContainer(IntPtr m);
    [DllImport(CppDllPath)]
    public static extern string GetMoveFinalLocation(IntPtr m);
    [DllImport(CppDllPath)]
    public static extern uint GetMoveTime(IntPtr m);

    //Container Functions
    [DllImport(CppDllPath)]
    public static extern IntPtr ConstructContainer(string l, string d, int w);
    [DllImport(CppDllPath)]
    public static extern string GetContainerLocation(IntPtr c);
    [DllImport(CppDllPath)]
    public static extern string GetContainerDescription(IntPtr c);
    [DllImport(CppDllPath)]
    public static extern int GetContainerWeight(IntPtr c);
    [DllImport(CppDllPath)]
    public static extern void SetContainerWeight(IntPtr c, int w);
}

