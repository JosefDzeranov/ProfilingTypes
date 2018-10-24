using System;
using Profiling;

public class CallRunner : IRunner
{
    private void PC1(C1 o)
    {
    }

    private void PS1(S1 o)
    {
    }

    private void PC2(C2 o)
    {
    }

    private void PS2(S2 o)
    {
    }

    private void PC4(C4 o)
    {
    }

    private void PS4(S4 o)
    {
    }

    private void PC8(C8 o)
    {
    }

    private void PS8(S8 o)
    {
    }

    private void PC16(C16 o)
    {
    }

    private void PS16(S16 o)
    {
    }

    private void PC32(C32 o)
    {
    }

    private void PS32(S32 o)
    {
    }

    private void PC64(C64 o)
    {
    }

    private void PS64(S64 o)
    {
    }

    private void PC128(C128 o)
    {
    }

    private void PS128(S128 o)
    {
    }

    private void PC256(C256 o)
    {
    }

    private void PS256(S256 o)
    {
    }

    private void PC512(C512 o)
    {
    }

    private void PS512(S512 o)
    {
    }

    public void Call(bool isClass, int size, int count)
    {
        if (isClass && size == 1)
        {
            var o = new C1();
            for (var i = 0; i < count; i++) PC1(o);
            return;
        }

        if (!isClass && size == 1)
        {
            var o = new S1();
            for (var i = 0; i < count; i++) PS1(o);
            return;
        }

        if (isClass && size == 2)
        {
            var o = new C2();
            for (var i = 0; i < count; i++) PC2(o);
            return;
        }

        if (!isClass && size == 2)
        {
            var o = new S2();
            for (var i = 0; i < count; i++) PS2(o);
            return;
        }

        if (isClass && size == 4)
        {
            var o = new C4();
            for (var i = 0; i < count; i++) PC4(o);
            return;
        }

        if (!isClass && size == 4)
        {
            var o = new S4();
            for (var i = 0; i < count; i++) PS4(o);
            return;
        }

        if (isClass && size == 8)
        {
            var o = new C8();
            for (var i = 0; i < count; i++) PC8(o);
            return;
        }

        if (!isClass && size == 8)
        {
            var o = new S8();
            for (var i = 0; i < count; i++) PS8(o);
            return;
        }

        if (isClass && size == 16)
        {
            var o = new C16();
            for (var i = 0; i < count; i++) PC16(o);
            return;
        }

        if (!isClass && size == 16)
        {
            var o = new S16();
            for (var i = 0; i < count; i++) PS16(o);
            return;
        }

        if (isClass && size == 32)
        {
            var o = new C32();
            for (var i = 0; i < count; i++) PC32(o);
            return;
        }

        if (!isClass && size == 32)
        {
            var o = new S32();
            for (var i = 0; i < count; i++) PS32(o);
            return;
        }

        if (isClass && size == 64)
        {
            var o = new C64();
            for (var i = 0; i < count; i++) PC64(o);
            return;
        }

        if (!isClass && size == 64)
        {
            var o = new S64();
            for (var i = 0; i < count; i++) PS64(o);
            return;
        }

        if (isClass && size == 128)
        {
            var o = new C128();
            for (var i = 0; i < count; i++) PC128(o);
            return;
        }

        if (!isClass && size == 128)
        {
            var o = new S128();
            for (var i = 0; i < count; i++) PS128(o);
            return;
        }

        if (isClass && size == 256)
        {
            var o = new C256();
            for (var i = 0; i < count; i++) PC256(o);
            return;
        }

        if (!isClass && size == 256)
        {
            var o = new S256();
            for (var i = 0; i < count; i++) PS256(o);
            return;
        }

        if (isClass && size == 512)
        {
            var o = new C512();
            for (var i = 0; i < count; i++) PC512(o);
            return;
        }

        if (!isClass && size == 512)
        {
            var o = new S512();
            for (var i = 0; i < count; i++) PS512(o);
            return;
        }

        throw new ArgumentException();
    }
}