import tkinter as tk
import tkinter.messagebox
from tkinter import *
from tkinter import ttk
import time

class VentanaPrincipal:
    def __init__(self, master):
        self.master = master
        master.title("Analizador lexico")
        master.geometry("600x600")
        self.menu = Menu(master)
        master.config(menu=self.menu)
        self.AFNS = Menu(self.menu, tearoff=0)
        self.AFNS.add_command(label="Basico", command=self.basico)
        self.AFNS.add_command(label="Unir", command=self.unir)
        self.AFNS.add_command(label="Concatenar")
        self.AFNS.add_command(label="Cerradura +")
        self.AFNS.add_command(label="Cerradura *")
        self.AFNS.add_command(label="Opcional")
        self.AFNS.add_separator()
        self.AFNS.add_command(label="ER -> AFN")
        self.AFNS.add_command(label="Union para analizador lexico")
        self.AFNS.add_command(label="Convertir AFN a AFD")
        self.AFNS.add_command(label="Analizar una cadena")
        self.AFNS.add_command(label="Probar analizador lexico")

        self.AnalisisLexico = Menu(self.menu, tearoff=0)

        self.menu.add_cascade(label="AFN's", menu=self.AFNS)
        self.menu.add_cascade(label="Analisis Lexico", menu=self.AnalisisLexico)
        self.listaID=[ ]

    def basico(self):
        self.ventBasico = tk.Toplevel(self.master)
        self.ventBasico.geometry("500x500+300+300")
        self.ventBasico.title("Basico")

        self.Car_Inf = tk.Label(self.ventBasico, text="Caracter inferior")
        self.Car_Inf.pack(pady=5)
        self.Car_Inf.place(x=10, y=10)

        self.var_CarInf = tk.Entry(self.ventBasico)
        self.var_CarInf.pack(pady=5)
        self.var_CarInf.place(x=120, y=10)

        self.Car_Sup = tk.Label(self.ventBasico, text="Caracter Superior")
        self.Car_Sup.pack(pady=5)
        self.Car_Sup.place(x=10, y=50)

        self.var_CarSup = tk.Entry(self.ventBasico)
        self.var_CarSup.pack(pady=5)
        self.var_CarSup.place(x=120, y=50)

        self.ID = tk.Label(self.ventBasico, text="ID")
        self.ID.pack(pady=5)
        self.ID.place(x=10, y=90)

        self.var_ID = tk.Entry(self.ventBasico)
        self.var_ID.pack(pady=5)
        self.var_ID.place(x=120, y=90)

        self.boton_guardar = tk.Button(self.ventBasico, text="Crear AFN", command=self.guardar_basico)
        self.boton_guardar.pack(pady=5)
        self.boton_guardar.place(x=300, y=50)


    def guardar_basico(self):
        CarInf = self.var_CarInf.get()
        CarSup = self.var_CarSup.get()
        ID = self.var_ID.get()
        if(len(CarSup) == 1 and len(CarInf) == 1 ):
            self.Alerta = tkinter.messagebox.showinfo(title="AFD creado", message="AFN basico creado")
            self.agregarID(ID)
            self.ventBasico.destroy()

        else:
            mensaje = "El caracter debe contener un unico elemento"
            self.label_mensaje = tk.Label(self.ventBasico, text=mensaje)
            self.label_mensaje.pack(pady=5)
            self.label_mensaje.place(x=150, y=180)

    def agregarID(self,ID):
        self.listaID.append(ID)
        print(self.listaID)



    def unir(self):
        self.ventUnir = tk.Toplevel(self.master)
        self.ventUnir.geometry("500x500+300+300")
        self.ventUnir.title("Basico")
        self.varID1= tk.StringVar()
        self.varID2= tk.StringVar()

        self.PrimerID = tk.Label(self.ventUnir, text="Primer ID")
        self.PrimerID.pack(pady=5)
        self.PrimerID.place(x=10, y=10)

        self.var_PrimerID = ttk.Combobox(self.ventUnir,state="readonly", values=self.listaID, width=5)
        self.var_PrimerID.pack(pady=5)
        self.var_PrimerID.place(x=120, y=10)

        self.SegundoID = tk.Label(self.ventUnir, text="Segundo ID")
        self.SegundoID.pack(pady=5)
        self.SegundoID.place(x=10, y=40)

        self.var_SegundoID = ttk.Combobox(self.ventUnir, state="readonly", values=self.listaID, width=5)
        self.var_SegundoID.pack(pady=5)
        self.var_SegundoID.place(x=120, y=40)
        selected1 = self.varID1.get()
        selected2 = self.varID2.get()
        self.varID1.trace('w', self.Actualizar(selected1,selected2))
        self.varID2.trace('w', self.Actualizar(selected1,selected2))

    def Actualizar(self,selected1,selected2):
        print("entre")
        selected1 = selected1
        selected2 = selected2

        options1 = list(filter(lambda  x: x != selected2, self.listaID))
        options2 = list(filter(lambda  x: x != selected1, self.listaID))

        self.var_PrimerID['values'] = options1
        self.var_SegundoID['values'] =options2



root = tk.Tk()
ventana_principal = VentanaPrincipal(root)
root.mainloop()
