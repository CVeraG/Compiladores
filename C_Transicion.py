class C_Transicion:

    def __init__(self, simb1=None, simb2=None, e=None):
            if simb2 is None:
                if e is None:
                    self.Edo = None
                else:
                    self.SimbInf1 = simb1
                    self.SimbSup1 = simb1
                    self.Edo = e
            else:
                self.SimbInf1 = simb1
                self.SimbSup1 = simb2
                self.Edo = e

    #No creo que se ocupe jaja
    def SetTransicion(self, s1, e, s2 = None):
        if s2 is None:
            self.SimbInf1 = s1
            self.SimbSup1 = s1
            self.Edo = e
        else:
            self.SimbInf1 = s1
            self.SimbSup1 = s2
            self.Edo = e
        return

    #No creo que se ocupe x2 jaja
    def GetEdoTrans(self, s):
        if self.SimbInf1 <= s <= self.SimbSup1:
            return self.Edo
        return None
    
