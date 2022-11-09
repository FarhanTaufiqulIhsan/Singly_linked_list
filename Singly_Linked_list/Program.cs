using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_list
{
    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    
    }

    class List
    {
        Node START;
        public List()
        {
            START = null;
        }

        public void addNode()/*method untuk menambahkan sebuah Node kedalam List*/
        {
            int nim;
            string nm;
            Console.WriteLine("\nMasukkan nomer Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;

            if (START == null || nim <= START.noMhs) /*Node ditambahkan sebagai node*/
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nNomor mahasiswa sama tidak diijinkan\n");
                    return;
                }
                nodeBaru.next = START;
                START = nodeBaru;
                return;
            }

            /*menemukan lokasi node baru didalam list*/

            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.noMhs))
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nNomor mahasiswa sama tidak diijinkan\n");
                    return ;
                }
                previous = current;
                current = current.next;
            }
            /*Node baru akan ditempatkan diantara previous dan current*/

            nodeBaru.next = current;
            previous.next = nodeBaru;
        }
    }
}
