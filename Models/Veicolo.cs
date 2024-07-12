using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters;

namespace ToRental.Models
{
    public class Veicolo
    {
        //The Unique identifier of this Model (unsigned int(20) NOT NULL AUTO INCREMENT)
        public int id { get; set; }

        //the chassis number of this vehicle (varchar(30) NOT NULL) - UNIQUE
        public string telaio { get; set; }
        [Required, StringLength(30)]

        //Foreign key referencing the data of the owner of this vehicle stored in the table "impostazione_proprietario_veicolo" (unsigned int(20) NOT NULL)
        public int id_proprietario { get; set; }

        //Foreign key referencing the data of the type of vehicle stored in the table "impostazione_tipo_veicolo" (unsigned int(20) NOT NULL)
        public int id_tipo_veicolo { get; set; }

        //Foreign key referencing the data of the type of setup stored in the table "impostazione_allestimento_veicolo" (unsigned int(20) NOT NULL)
        public int id_tipo_allestimento { get; set; }

        //Foreign key referencing the data of the brand of this vehicle stored in the table "impostazione_marca_veicolo" (unsigned int(20) NOT NULL)
        public int id_marca { get; set; }

        //Foreign key referencing the data of the model of this vehicle stored in the table "impostazione_modello_veicolo" (unsigned int(20) NOT NULL)
        public int id_modello { get; set; }

        //Foreign key referencing the data of the type of axis of this vehicle stored in the table "impostazione_asse_veicolo" (unsigned int(20) NOT NULL)
        public int id_tipo_asse { get; set; }

        //Foreign key referencing the data of the type of power of this vehicle stored in the table "impostazione_cambio_veicolo" (unsigned int(20) NOT NULL)
        public int id_tipo_cambio { get; set; }

        //Foreign key referencing the data of the type of fuel of this vehicle stored in the table "impostazione_alimentazione_veicolo" (unsigned int(20) NOT NULL)
        public int id_alimentazione { get; set; }

        //Foreign key referencing the data of the type of emission of this vehicle stored in the table "impostazione_destinazione_veicolo" (unsigned int(20) NOT NULL)
        public int id_destinazione_uso { get; set; }

        //Foreign key referencing the data of the type of emission of this vehicle stored in the table "impostazione_disponibilita_veicolo" (unsigned int(20) NOT NULL)
        public int id_disponibilita { get; set; }

        //Foreign key referencing the data of the type of emission of this vehicle stored in the table "impostazione_stato_veicolo" (unsigned int(20) NOT NULL)
        public int id_stato { get; set; }

        public string altre_caratteristiche { get; set; }

        public string note { get; set; }

        public string colore { get; set; }

        public decimal lunghezza_esterna { get; set; }

        public decimal larghezza_esterna { get; set; }

        public decimal massa { get; set; }

        public decimal portata { get; set; }

        public int cilindrata { get; set; }

        public int potenza { get; set; }

        public int numero_assi { get; set; }

        public DateTime checked_at { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }

        internal IEnumerable<Veicolo> GetAll() {
            //creates a list of 10 random Veicolo and returns them
            List<Veicolo> veicoli = new List<Veicolo>();

            return new Veicolo();


        }
    }
}
