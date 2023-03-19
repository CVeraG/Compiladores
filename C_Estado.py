class Estado:
    contador_IdEstado = 0
    
    def __init__(self):
        self.e_aceptacion = False
        self.token = -1

        self.contador_IdEstado += 1
        self.IdEstado = self.contador_IdEstado
        self.trans = set()
        self.trans.clear()
        
