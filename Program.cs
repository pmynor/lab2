using System;
using System.Collections.Generic;
using CentroEducativoLab.Edu.Kinal.Lab.Entities;

namespace CentroEducativoLab
{
    public class Program
    {
        static List<Persona> listaGeneral = new List<Persona>();
        static void Main(string[] args)
        {
            Alumno alumno1 =new Alumno("1234","Portillo","Mynor","pmynor@gmail.com","001",1);
            Persona alumno2 =new Alumno("43456","Fernandez","Luna","luna@gmail.com","002",3);
            Profesor profesor1 =new Profesor("B01","Lopez","Miguel","Lopez@gmail.com","343434","Ciencias");
            Persona profesor2 = new Profesor("B02","Galdamez","jose","jose@gmail.com","T-001","Sociales");
            OperarRegistro(alumno1);
            OperarRegistro(alumno2);
            OperarRegistro(profesor1);
            OperarRegistro(profesor2);

            foreach (var persona in listaGeneral){
                RegistrarAsistecia(persona);
                VerMisDatos(persona);
            }
            QuitarAsignatura(alumno2);
            QuitarAsignatura(profesor1);

        }
        static void OperarRegistro(Persona persona){
            listaGeneral.Add(persona);
        }
        static void RegistrarAsistecia(Persona persona){
            if(persona is Profesor){
                ((Profesor)persona).TomarAsistencia();
            }
            if(persona is Alumno){
                ((Alumno)persona).TomarAsistencia();
            }
        }
        static void VerMisDatos(Persona persona){
            if(persona is Profesor){
                ((Profesor)persona).ListarMisDatos(((Profesor)persona).CUI);
            }else if(persona is Alumno){
                ((Alumno)persona).ListarMisDatos(((Alumno)persona).Carne);
            }
        }
        static void QuitarAsignatura(Persona persona){
            if (persona is Profesor){
                ((Profesor)persona).EliminarAsignatura("Ciencias");
                } else if (persona is Alumno){
                    ((Alumno)persona).EliminarAsignatura("Sociales");
                }
            }
            
        }
    }
