using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;


namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascotas = new RepositorioMascota(new Persistencia.AppContext());
        //private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        //private static IRepositorioVisitaPyP _repoVisitasPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Trabajando en las Tablas");
            //AddDueno();
            //AddVeterinario();
            //AddMascota();
            //BuscarDueno(1);
            //BuscarMascota(2);
            //ListaDueno();
            //
            ListaMascota();
            
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Nicolas",
                Apellidos = "Steven",
                Direccion = "En algun planeta",
                Telefono = "3102506280",
                Correo = "nicolas.vanegas.bello@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Carlos",
                Apellidos = "Bello",
                Direccion = "En un Arecife",
                Telefono = "0987654321",
                TarjetaProfesional = "Veteriaria Ortopedica"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Max",
                Color = "TriColor",
                Especie = "Especie",
                Raza = "Shih Tzu"
            };
            _repoMascotas.AddMascota(mascota);   
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void ListaDueno()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);   
            }
            
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascotas.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Raza + " " + mascota.Especie + " ");
        }

        private static void ListaMascota()
        {
            var mascota = _repoMascotas.GetAllMascotas();
            foreach (Mascota d in mascota)
            {
                Console.WriteLine(d.Nombre + " " + d.Raza);   
            }
            
        }
    }
}
