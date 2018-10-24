using System;
using Profiling;

public class ArrayRunner : IRunner
{
    private void PC1()
    {
        var array = new C1[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C1();
    }

    private void PS1()
    {
        var array = new S1[Constants.ArraySize];
    }

    private void PC2()
    {
        var array = new C2[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C2();
    }

    private void PS2()
    {
        var array = new S2[Constants.ArraySize];
    }

    private void PC4()
    {
        var array = new C4[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C4();
    }

    private void PS4()
    {
        var array = new S4[Constants.ArraySize];
    }

    private void PC8()
    {
        var array = new C8[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C8();
    }

    private void PS8()
    {
        var array = new S8[Constants.ArraySize];
    }

    private void PC16()
    {
        var array = new C16[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C16();
    }

    private void PS16()
    {
        var array = new S16[Constants.ArraySize];
    }

    private void PC32()
    {
        var array = new C32[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C32();
    }

    private void PS32()
    {
        var array = new S32[Constants.ArraySize];
    }

    private void PC64()
    {
        var array = new C64[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C64();
    }

    private void PS64()
    {
        var array = new S64[Constants.ArraySize];
    }

    private void PC128()
    {
        var array = new C128[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C128();
    }

    private void PS128()
    {
        var array = new S128[Constants.ArraySize];
    }

    private void PC256()
    {
        var array = new C256[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C256();
    }

    private void PS256()
    {
        var array = new S256[Constants.ArraySize];
    }

    private void PC512()
    {
        var array = new C512[Constants.ArraySize];
        for (var i = 0; i < Constants.ArraySize; i++) array[i] = new C512();
    }

    private void PS512()
    {
        var array = new S512[Constants.ArraySize];
    }

    public void Call(bool isClass, int size, int count)
    {
        if (isClass && size == 1)
        {
            for (var i = 0; i < count; i++) PC1();
            return;
        }

        if (!isClass && size == 1)
        {
            for (var i = 0; i < count; i++) PS1();
            return;
        }

        if (isClass && size == 2)
        {
            for (var i = 0; i < count; i++) PC2();
            return;
        }

        if (!isClass && size == 2)
        {
            for (var i = 0; i < count; i++) PS2();
            return;
        }

        if (isClass && size == 4)
        {
            for (var i = 0; i < count; i++) PC4();
            return;
        }

        if (!isClass && size == 4)
        {
            for (var i = 0; i < count; i++) PS4();
            return;
        }

        if (isClass && size == 8)
        {
            for (var i = 0; i < count; i++) PC8();
            return;
        }

        if (!isClass && size == 8)
        {
            for (var i = 0; i < count; i++) PS8();
            return;
        }

        if (isClass && size == 16)
        {
            for (var i = 0; i < count; i++) PC16();
            return;
        }

        if (!isClass && size == 16)
        {
            for (var i = 0; i < count; i++) PS16();
            return;
        }

        if (isClass && size == 32)
        {
            for (var i = 0; i < count; i++) PC32();
            return;
        }

        if (!isClass && size == 32)
        {
            for (var i = 0; i < count; i++) PS32();
            return;
        }

        if (isClass && size == 64)
        {
            for (var i = 0; i < count; i++) PC64();
            return;
        }

        if (!isClass && size == 64)
        {
            for (var i = 0; i < count; i++) PS64();
            return;
        }

        if (isClass && size == 128)
        {
            for (var i = 0; i < count; i++) PC128();
            return;
        }

        if (!isClass && size == 128)
        {
            for (var i = 0; i < count; i++) PS128();
            return;
        }

        if (isClass && size == 256)
        {
            for (var i = 0; i < count; i++) PC256();
            return;
        }

        if (!isClass && size == 256)
        {
            for (var i = 0; i < count; i++) PS256();
            return;
        }

        if (isClass && size == 512)
        {
            for (var i = 0; i < count; i++) PC512();
            return;
        }

        if (!isClass && size == 512)
        {
            for (var i = 0; i < count; i++) PS512();
            return;
        }

        throw new ArgumentException();
    }
}