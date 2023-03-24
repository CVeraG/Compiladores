class Estado:
    contador_IdEstado = 0
    
    def __init__(self):
        self.IdEstado1 = Estado.contador_IdEstado
        Estado.contador_IdEstado += 1
        self.e_aceptacion1 = False
        self.token1 = -1

        self.trans1 = set()
        self.trans1.clear()

    @property
    def IdEstado(self):
        return self.IdEstado1

    @IdEstado.setter
    def IdEstado(self, value):
        self.IdEstado1 = value

    @property
    def EdoAcept(self):
        return self.e_aceptacion1

    @EdoAcept.setter
    def EdoAcept(self, value):
        self.e_aceptacion1 = value

    @property
    def Token(self):
        return self.token1

    @Token.setter
    def Token(self, value):
        self.token1 = value

    @property
    def Trans(self):
        return self.trans1

    @Trans.setter
    def Trans(self, value):
        self.trans1 = value


        
