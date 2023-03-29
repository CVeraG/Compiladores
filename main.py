from C_AFN import AFN
import C_Estado

# Crear un AFN básico con un símbolo
afn1 = AFN().CrearAFNBasico('a','a')
#afn1.ImprimirEdosAFN()
afn2 = AFN().CrearAFNBasico('b','b')
#afn2.ImprimirEdosAFN()
#afn1.ImprimirEdosAFN()

#afn1.UnirAFN(afn2)
#afn1.EdosAFN |= afn2.EdosAFN
#afn1.ConcAFN(afn2)
#afn1.CerrPos()
#afn1.CerrKleen()
afn1.Opcional()
afn1.ImprimirEdosAFN()

# Crear un AFN básico con un rango de símbolos
#afn2 = AFN().CrearAFNBasico('0', '9')