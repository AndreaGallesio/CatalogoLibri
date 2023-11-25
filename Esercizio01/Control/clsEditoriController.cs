using Esercizio01.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio01.Control
{
    class clsEditoriController
    {
        private adoNetSQL sqlEditori;
        private bool pErrore;
        private string pStrSQL;
        private List<clsEditori> listaEditori;

        public clsEditori Editore;
        public string msgErrore;

        public clsEditoriController()
        {
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlEditori = new adoNetSQL(pathDB);
            Editore = new clsEditori();
            Editore.ValEditore = ' ';
            msgErrore = string.Empty;
        }

        public bool aggiungi()
        {
            pErrore = false;

            sqlEditori.cmd.Parameters.AddWithValue("@IEditore", Editore.IdEditore);
            sqlEditori.cmd.Parameters.AddWithValue("@NoEditore", Editore.NomeEditore);
            sqlEditori.cmd.Parameters.AddWithValue("@VEditore", Editore.ValEditore);

            pStrSQL = "INSERT INTO Editori " +
                "(NomeEditore, ValEditore) " +
                "VALUES (@NoEditore, @VEditore)";

            try
            {
                int Risultato = sqlEditori.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Autore inserito correttamente !!!";
            }

            return pErrore;
        }

        public bool modifica()
        {
            pErrore = false;

            sqlEditori.cmd.Parameters.AddWithValue("@IEditore", Editore.IdEditore);
            sqlEditori.cmd.Parameters.AddWithValue("@NoEditore", Editore.NomeEditore);
            sqlEditori.cmd.Parameters.AddWithValue("@VEditore", Editore.ValEditore);

            pStrSQL = "UPDATE Editori SET " +
                        "NomeEditore = @NoEditore, ValEditore = @VEditore " +
                        "WHERE IdEditore = @IEditore";

            try
            {
                int Risultato = sqlEditori.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Autore modificato correttamente !!!";
            }


            return pErrore;
        }

        public bool cancella()
        {
            pErrore = false;

            sqlEditori.cmd.Parameters.AddWithValue("@IEditore", Editore.IdEditore);

            pStrSQL = "UPDATE Editori SET " +
                        "ValEditore = 'A' " +
                        "WHERE IdEditore = @IEditore";

            try
            {
                int Risultato = sqlEditori.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Autore cancellato correttamente !!!";
            }

            return pErrore;
        }

        public bool ripristina()
        {
            pErrore = false;

            sqlEditori.cmd.Parameters.AddWithValue("@IEditore", Editore.IdEditore);

            pStrSQL = "UPDATE Editori SET " +
                        "ValEditore = '' " +
                        "WHERE IdEditore = @IEditore";

            try
            {
                int Risultato = sqlEditori.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Autore ripristina correttamente !!!";
            }

            return pErrore;
        }

        public bool chkEditore()
        {
            bool controllo = true;
            string Risultato = string.Empty;

            sqlEditori.cmd.Parameters.AddWithValue("@IEditore", Editore.IdEditore);

            pStrSQL = "SELECT COUNT(*) FROM Editori " +
                        "WHERE IdEditore = @IEditore";

            try
            {
                Risultato = sqlEditori.eseguiScalar(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                controllo = false;
            }
            finally
            {
                if (controllo)
                    if (Convert.ToInt32(Risultato) != 0)
                    {
                        msgErrore = $"Il Autore [{Editore.IdEditore}] è già presente !!!";
                        controllo = false;
                    }

            }

            return controllo;
        }

        public List<clsEditori> elencoEditori()
        {
            listaEditori = new List<clsEditori>();

            pStrSQL = "SELECT *" +
                " FROM Editori" +
                " WHERE ValEditore = '' " +
                "ORDER BY IdEditore";

            caricaListaEditori();

            return listaEditori;
        }

        public List<clsEditori> elencoEditoriAnnullati()
        {
            listaEditori = new List<clsEditori>();

            pStrSQL = "SELECT * " +
                "FROM Editori " +
                "WHERE ValEditore = 'A' " +
                "ORDER BY IdEditore";

            caricaListaEditori();

            return listaEditori;
        }

        private void caricaListaEditori()
        {

            SqlDataReader dataReader;

            pErrore = false;

            try
            {
                dataReader = sqlEditori.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsEditori detEditore = new clsEditori();
                    detEditore.IdEditore = Convert.ToInt32(dataReader["IdEditore"]);
                    detEditore.NomeEditore = dataReader["NomeEditore"].ToString();
                    detEditore.ValEditore = Convert.ToChar(dataReader["ValEditore"]);
                    listaEditori.Add(detEditore);
                }
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                {
                    msgErrore = "Lista creata con Successo !!";
                    sqlEditori.chiudiLettore();
                }
            }

        }

        public clsEditori datiEditore()
        {
            pErrore = false;
            clsEditori modEditore = new clsEditori();
            DataTable tabellaEditori = null;

            sqlEditori.cmd.Parameters.AddWithValue("@IEditore", Editore.IdEditore);

            pStrSQL = "SELECT NomeEditore, ValEditore FROM Editori " +
                        "WHERE IdEditore = @IEditore";

            try
            {
                tabellaEditori = sqlEditori.eseguiQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                {
                    modEditore.IdEditore = Editore.IdEditore;
                    modEditore.NomeEditore = tabellaEditori.Rows[0].ItemArray[0].ToString();
                    modEditore.ValEditore = Convert.ToChar(tabellaEditori.Rows[0].ItemArray[1]);
                }
            }

            return modEditore;
        }
        public bool getEditore()
        {
            pErrore = false;

            sqlEditori.cmd.Parameters.AddWithValue("@NomeEditore", Editore.NomeEditore);

            pStrSQL = "SELECT IdEditore FROM Editori WHERE NomeEditore = @NomeEditore";

            try
            {
                string risultato = sqlEditori.eseguiScalar(pStrSQL, CommandType.Text);
                Editore.IdEditore = Convert.ToInt32(risultato);
            }
            catch (Exception ex)
            {
                msgErrore = $"attenzione: - [{ex.Message}]";
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "editore trovato con successo";
            }

            return pErrore;
        }
        public bool getEditoreId()
        {
            pErrore = false;

            sqlEditori.cmd.Parameters.AddWithValue("@IdEditore", Editore.IdEditore);

            pStrSQL = "SELECT NomeEditore FROM Editori WHERE IdEditore = @IdEditore";

            try
            {
                string risultato = sqlEditori.eseguiScalar(pStrSQL, CommandType.Text);
                Editore.NomeEditore = risultato;
            }
            catch (Exception ex)
            {
                msgErrore = $"attenzione: - [{ex.Message}]";
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "editore trovato con successo";
            }

            return pErrore;
        }
    }
}
