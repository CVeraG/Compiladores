import C_Estado, C_Transicion, SimbolosEspeciales


class AFN:
    ConjDeAFNs = set()
    EdoIni = C_Estado.Estado
    EdosAFN = set()
    EdosAcept = set()
    Alfabeto = set()
    IdAFN = 0

    def __init__(self):
        self.IdAFN = 0
        self.EdoIni = None
        self.EdosAFN.clear()
        self.EdosAcept.clear()
        self.Alfabeto.clear()
        print("Entre al constructor")

    def CrearAFNBasico(self, s1, s2):
        e1 = C_Estado.Estado()
        print(f"basico{e1.IdEstado}")
        e2 = C_Estado.Estado()
        print(e2.IdEstado)
        if s1 == s2:
            t = C_Transicion.C_Transicion(s1, e2)
            e1.Trans.add(t)
            e2.EdoAcept = True
            self.Alfabeto.add(s1)
            self.EdoIni = e1
            self.EdosAFN.add(e1)
            self.EdosAFN.add(e2)
            self.EdosAcept.add(e2)
            return self
        else:
            t = C_Transicion.C_Transicion(s1, s2, e2)
            e1.Trans.add(t)
            e2.EdoAcept = True
            for i in range(ord(s1), ord(s2) + 1):
                self.Alfabeto.add(chr(i))
            self.EdoIni = e1
            self.EdosAFN.add(e1)
            self.EdosAFN.add(e2)
            self.EdosAcept.add(e2)
            return self

    def UnirAFN(self, f2):
        e1 = C_Estado.Estado()
        print(e1.IdEstado)
        e2 = C_Estado.Estado()
        print(e2.IdEstado)
        t1 = C_Transicion.C_Transicion(SimbolosEspeciales.SimbolosEspeciales.EPSILON, self.EdoIni)
        t2 = C_Transicion.C_Transicion(SimbolosEspeciales.SimbolosEspeciales.EPSILON, f2.EdoIni)
        e1.Trans.add(t1)
        e1.Trans.add(t2)
        for e in self.EdosAcept:
            e.Trans.add(C_Transicion.C_Transicion(SimbolosEspeciales.SimbolosEspeciales.EPSILON, e2))
            e.EdoAcept = False
        for e in f2.EdosAcept:
            e.Trans.add(C_Transicion.C_Transicion(SimbolosEspeciales.SimbolosEspeciales.EPSILON, e2))
            e.EdoAcept = False
        self.EdosAcept.clear()
        f2.EdosAcept.clear()
        self.EdoIni = e1
        e2.EdoAcept = True
        self.EdosAcept.add(e2)
        self.EdosAFN |= f2.EdosAFN
        self.EdosAFN.add(e1)
        self.EdosAFN.add(e2)
        self.Alfabeto |= f2.Alfabeto
        return self

    def ImprimirEdosAFN(self):
        print("Estados del AFN:")
        for estado in self.EdosAFN:
            print(estado)





