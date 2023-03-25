class C_Transicion:
    def __init__(self, simb1=None, simb2=None, e=None):
        self.SimbInf1 = simb1
        self.SimbSup1 = simb2
        self.Edo = e
    #No creo que se ocupe jaja
    def SetTransicion(self, s1, s2, e):
        SimbInf1 = s1
        SimbSup1 = s2
        Edo = e
        return
    #No creo que se ocupe x2 jaja
    def GetEdoTrans(self, s):
        if (self.SimbInf1 <= s && s <= self.SimbSup1)
            return self.Edo
        return None
    
