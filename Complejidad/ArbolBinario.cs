using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejidad
{
    public class ArbolBinario<t>
    {
        private t dato;
        private ArbolBinario<t> hijoIzquierdo;
        private ArbolBinario<t> hijoDerecho;
        public ArbolBinario(t dato)
        {
            this.dato = dato;
            this.hijoIzquierdo = null;
            this.hijoDerecho = null;
        }

        public t Dato {
            get { return dato; }
            set { dato = value; }
        }
        public ArbolBinario<t> HijoIzquierdo
        {
            get { return hijoIzquierdo; }
            set { hijoIzquierdo = value; }
        }
        public ArbolBinario<t> HijoDerecho
        {
            get { return hijoDerecho; }
            set { hijoDerecho = value; }
        }

        public void insertarhijoizquierdo(t dato)
        {
            if (this.hijoIzquierdo==null)
            {
                this.hijoIzquierdo= new ArbolBinario<t>(dato);
            }
            else
            {
                Console.WriteLine("El hijo izquierdo ya existe");


            }
        }

        public void insertarhijoderecho(t dato)
        {
            if (this.hijoDerecho == null)
            {
                this.hijoDerecho = new ArbolBinario<t>(dato);
            }
            else
            {
                Console.WriteLine("El hijo derecho ya existe");


            }
        }



    }
}
