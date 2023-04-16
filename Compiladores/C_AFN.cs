using System;
using System.Collections.Generic;
using System.Linq;
using Compiladores;

public class ConjIj
{
    public int j;
    public HashSet<Estado> ConjI;
    public int[] TransicionesAFD;
    public ConjIj(int CardAlf)
    {
        j = -1;
        ConjI = new HashSet<Estado>();
        ConjI.Clear();
        TransicionesAFD = new int[256];
        for (int k = 0; k < 256; k++)
            TransicionesAFD[k] = -1;
    }
}

public class AFN
{
    public static HashSet<AFN> ConjDeAFNs = new HashSet<AFN>();
    Estado EdoIni;
    HashSet<Estado> EdosAFN = new HashSet<Estado>();
    HashSet<Estado> EdosAcept = new HashSet<Estado>();
    HashSet<char> Alfabeto = new HashSet<char>();
    bool SeAgregoAFNUnionLexico;
    public int IdAFN;
    public AFN()
    {
        IdAFN = 0;
        EdoIni = null;
        EdosAFN.Clear();
        EdosAcept.Clear();
        Alfabeto.Clear();
        SeAgregoAFNUnionLexico = false;
    }

    public AFN CrearAFNBasico(char s)
    {
        Transicion t;
        Estado e1, e2;
        e1 = new Estado();
        e2 = new Estado();
        t = new Transicion(s, e2);
        e1.Trans.Add(t);
        e2.EdoAcept = true;
        _ = Alfabeto.Add(s);
        EdoIni = e1;
        _ = EdosAFN.Add(e1);
        _ = EdosAFN.Add(e2);
        _ = EdosAcept.Add(e2);
        return this;
    }
    public AFN CrearAFNBasico(char s1, char s2)
    {
        //Validar que s1<=s2
        char i;
        Transicion t;
        Estado e1, e2;
        e1 = new Estado();
        e2 = new Estado();
        t = new Transicion(s1, s2, e2);
        _ = e1.Trans.Add(t);
        e2.EdoAcept = true;
        for (i = s1; i <= s2; i++)
            _ = Alfabeto.Add(i);
        EdoIni = e1;
        _ = EdosAFN.Add(e1);
        _ = EdosAFN.Add(e2);
        _ = EdosAcept.Add(e2);
        foreach (var Edos in this.EdosAFN)
        {
            Console.WriteLine(Edos.IdEstado);
        }
        return this;
        
    }
    public AFN UnirAFN(AFN f2)
    {
        Console.WriteLine("Entre a unir");
        Estado e1 = new Estado();
        Estado e2 = new Estado();
        // e1 tendrá dos transiciones epsilon. Una al edo inicial y uno al final
        Transicion t1 = new Transicion(SimbolosEspeciales.EPSILON, this.EdoIni);
        Transicion t2 = new Transicion(SimbolosEspeciales.EPSILON, f2.EdoIni);
        _ = e1.Trans.Add(t1);
        _ = e1.Trans.Add(t2);

        foreach (Estado e in this.EdosAcept)
        {
            _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e2));
            _ = e.EdoAcept = false;
        }
        foreach (Estado e in f2.EdosAcept)
        {
            _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e2));
            _ = e.EdoAcept = false;
        }
        this.EdosAcept.Clear();
        f2.EdosAcept.Clear();
        this.EdoIni = e1;
        e2.EdoAcept = true;
        this.EdosAcept.Add(e2);
        this.EdosAFN.UnionWith(f2.EdosAFN);
        this.EdosAFN.Add(e1);
        this.EdosAFN.Add(e2);
        this.Alfabeto.UnionWith(f2.Alfabeto);
        foreach (var Edos in this.EdosAFN)
        {
            Console.WriteLine(Edos.IdEstado);
        }
        return this;
    }
    public AFN ConcAFN(AFN f2)
    {
        Console.WriteLine("entre a conc");
        foreach (Transicion t in f2.EdoIni.Trans)
            foreach (Estado e in this.EdosAcept)
            {
                e.Trans.Add(t);
                e.EdoAcept = false;
            }
        f2.EdosAFN.Remove(f2.EdoIni);
        this.EdosAcept = f2.EdosAcept;
        this.EdosAFN.UnionWith(f2.EdosAFN);
        this.Alfabeto.UnionWith(f2.Alfabeto);
        foreach (var Edos in this.EdosAFN)
        {
            Console.WriteLine(Edos.IdEstado);
        }
        return this;
    }

    public AFN CerrPos()
    {
        Estado e_ini = new Estado();
        Estado e_fin = new Estado();

        e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
        foreach (Estado e in EdosAcept)
        {
            _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
            _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
            _ = e.EdoAcept = false;
        }
        EdoIni = e_ini;
        e_fin.EdoAcept = true;
        EdosAcept.Clear();
        EdosAFN.Add(e_ini);
        EdosAFN.Add(e_fin);
        foreach (var Edos in this.EdosAFN)
        {
            Console.WriteLine(Edos.IdEstado);
        }
        return this;
    }

    public AFN CerrKleen()
    {
        Estado e_ini = new Estado();
        Estado e_fin = new Estado();

        e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
        e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
        foreach (Estado e in EdosAcept)
        {
            _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
            _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
            _ = e.EdoAcept = false;
        }
        EdoIni = e_ini;
        e_fin.EdoAcept = true;
        EdosAcept.Clear();
        EdosAcept.Add(e_fin);
        EdosAFN.Add(e_ini);
        EdosAFN.Add(e_fin);
        foreach (var Edos in this.EdosAFN)
        {
            Console.WriteLine(Edos.IdEstado);
        }
        return this;
    }

    public AFN Opcional()
    {
        Estado e_ini = new Estado();
        Estado e_fin = new Estado();

        e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
        e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));

        foreach (Estado e in EdosAcept)
        {
            _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
            _ = e.EdoAcept = false;
        }
        EdoIni = e_ini;
        e_fin.EdoAcept = true;
        EdosAcept.Clear();
        EdosAcept.Add(e_fin);
        EdosAFN.Add(e_ini);
        EdosAFN.Add(e_fin);
        foreach (var Edos in this.EdosAFN)
        {
            Console.WriteLine(Edos.IdEstado);
        }
        return this;
    }
    public HashSet<Estado> CerraduraEpsilon(Estado e)
    {
         HashSet<Estado> R = new HashSet<Estado>();
         Stack<Estado> S = new Stack<Estado>();
         Estado aux, Edo;
         R.Clear();
         S.Clear();
         S.Push(e);
        while (S.Count != 0)
        {
            aux = S.Pop();
            R.Add(aux);
            foreach (Transicion t in aux.Trans)
                if ((Edo = t.GetEdoTrans(SimbolosEspeciales.EPSILON)) != null)
                    if (!R.Contains(Edo))
                        S.Push(Edo);

        }
        return R;
    }

    public HashSet<Estado> CerraduraEpsilon(HashSet<Estado> ConjEdos)
    {
        HashSet<Estado> R = new HashSet<Estado>();
        Stack<Estado> S = new Stack<Estado>();
        Estado aux, Edo;
        R.Clear();
        S.Clear();
        foreach (Estado e in ConjEdos)
        {
            S.Push(e);
        }    
        while (S.Count != 0)
        {
            aux = S.Pop();
            R.Add(aux);
            foreach (Transicion t in aux.Trans)
                if ((Edo = t.GetEdoTrans(SimbolosEspeciales.EPSILON)) != null)
                    if (!R.Contains(Edo))
                        S.Push(Edo);

        }
        return R;
    }

    public HashSet<Estado> Mover(Estado Edo, char Simb)
    {
        HashSet<Estado> C = new HashSet<Estado>();
        Estado Aux;
        C.Clear();

        foreach (Transicion t in Edo.Trans)
        {
            Aux = t.GetEdoTrans(Simb);
            if (Aux != null)
                C.Add(Aux);
        }
        return C;
    }


    public HashSet<Estado> Mover(HashSet<Estado> Edos, char Simb)
    {
        HashSet<Estado> C = new HashSet<Estado>();
        Estado Aux;
        C.Clear();
        foreach (Estado Edo in Edos)
            foreach (Transicion t in Edo.Trans)
            {
                Aux = t.GetEdoTrans(Simb);
                if (Aux != null)
                    C.Add(Aux);
            }
        return C;
    }

    public HashSet<Estado> Ir_A(HashSet<Estado> Edos, char Simb)
    {
    HashSet<Estado> C = new HashSet<Estado>();
    C.Clear();
    C=CerraduraEpsilon(ConjEdos: Mover(Edos, Simb));
    return C;
    }
    public void UnionEspecialAFNs(AFN f, int Token)
    {
        Console.WriteLine("entre a especial");
        Estado e;
        if (!this.SeAgregoAFNUnionLexico)
        {
            this.EdosAFN.Clear();
            this.EdosAFN.Clear();
            this.Alfabeto.Clear();
            e = new Estado();
            e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, f.EdoIni));
            this.EdoIni = e;
            this.EdosAFN.Add(e);
            this.SeAgregoAFNUnionLexico = true;
        
        }
           
        else
             this.EdoIni.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, f.EdoIni));
        foreach (Estado EdoAcep in f.EdosAcept)
            EdoAcep.Token = Token;
        this.EdosAcept.UnionWith(f.EdosAcept);
        this.EdosAFN.UnionWith(f.EdosAFN);
        this.Alfabeto.UnionWith(f.Alfabeto);
    }

    
    public AFD ConvAFNaAFD()
        {
        int Cardalfabeto, NumEdosAFD;
        int i, j, r;
        char[] ArrAlfabeto;
        ConjIj Ij, Ik;
        bool existe;
        HashSet<Estado> ConjaAux = new HashSet<Estado>();
        HashSet<ConjIj> EdosAFD = new HashSet<ConjIj>();
        Queue<ConjIj> EdosSinAnalizar = new Queue<ConjIj>();
        EdosAFD.Clear();
        EdosSinAnalizar.Clear();
        Cardalfabeto = Alfabeto.Count;
        ArrAlfabeto = new char[Cardalfabeto];
        i = 0;
        foreach (char c in Alfabeto)
            ArrAlfabeto[i++] = c;
        j = 0; //Contador para los estados del AFD
        Ij = new ConjIj(Cardalfabeto)
        {
            ConjI = CerraduraEpsilon(this.EdoIni),
            j = j
        };
        EdosAFD.Add(Ij);
        EdosSinAnalizar.Enqueue(Ij);
        j++;
        while (EdosSinAnalizar.Count != 0)
        {
            Ij = EdosSinAnalizar.Dequeue();
            //Calcular el IrA del Ij con cada simbolo del alfabeto
            foreach (char c in ArrAlfabeto)
            {
                Ik = new ConjIj(Cardalfabeto)
                {
                    ConjI = Ir_A(Ij.ConjI, c)
                };
                if (Ik.ConjI.Count == 0)
                    continue;
                existe = false;
                foreach (ConjIj I in EdosAFD)
                {
                    if (I.ConjI.SetEquals(Ik.ConjI))
                    {
                        existe = true;
                        r = (int)c;
                        Ij.TransicionesAFD[r] = I.j;
                        break;
                    }
                }
                if (!existe)
                {
                    Ik.j = j;
                    r = (int)c;
                    Ij.TransicionesAFD[r] = Ik.j;
                    EdosAFD.Add(Ik);
                    EdosSinAnalizar.Enqueue(Ik);
                    j++;
                }

            }
        }
        NumEdosAFD = j;
        int fila = 0;
        AFD afd = new AFD(NumEdosAFD);
        AFD.edosAFD = NumEdosAFD;
        int[,] tablaEdos = new int[NumEdosAFD, 256];
        foreach (ConjIj I in EdosAFD)
        {
            HashSet<Estado> es = new HashSet<Estado>(I.ConjI.Intersect(this.EdosAcept));
            if (es.Count != 0)
            {
               AFD.IjAcept.Add(I);
            }

            for (int x = 0; x < 256; x++)
            {
                tablaEdos[fila, x] = I.TransicionesAFD[x];
            }
            fila++;

        }
        
        afd.tablaEdos = tablaEdos;
        AFD.tablaAFD = tablaEdos;
        return afd;
        }
    
}

public class AFD
{
    public int IdAFD;
    public int[,] tablaEdos;
    public static int[,] tablaAFD;
    public static int edosAFD;
    public static HashSet<ConjIj> IjAcept = new HashSet<ConjIj>();
    public int Token;
    public AFD(int NumIj)
    {
        tablaEdos = new int[NumIj, 256];
        IdAFD = 0;
        IjAcept.Clear();
        Token = -1;
    }

    public int[,] GetTablaEdos()
    {
        return tablaEdos;
    }

}
    

