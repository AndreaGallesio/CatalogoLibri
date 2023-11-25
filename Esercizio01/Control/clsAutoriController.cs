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
    class clsAutoriController
    {
        private adoNetSQL sqlAurori;
        private bool pErrore;
        private string pStrSQL;
        private List<clsAutori> listaAutori;

        public clsAutori Autore;
        public string msgErrore;

        public clsAutoriController()
        {
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlAurori = new adoNetSQL(pathDB);
            Autore = new clsAutori();
            Autore.ValAutore = ' ';
            msgErrore = string.Empty;
        }

        public bool aggiungi()
        {
            pErrore = false;

            sqlAurori.cmd.Parameters.AddWithValue("@IdAutore", Autore.IdAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@CognAutore", Autore.CognAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@NomeAutore", Autore.NomeAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@DatNasAutore", Autore.DatNasAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@FotoAutore", Autore.FotoAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@ValAutore", Autore.ValAutore);

            pStrSQL = "INSERT INTO Autori " +
                "(CognAutore, NomeAutore, DatNasAutore, FotoAutore, ValAutore) " +
                " VALUES (@CognAutore, @NomeAutore, @DatNasAutore, @FotoAutore, @ValAutore)";

            try
            {
                int Risultato = sqlAurori.eseguiNonQuery(pStrSQL, CommandType.Text);
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

            sqlAurori.cmd.Parameters.AddWithValue("@IdAutore", Autore.IdAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@CognAutore", Autore.CognAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@NomeAutore", Autore.NomeAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@DatNasAutore", Autore.DatNasAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@FotoAutore", Autore.FotoAutore);
            sqlAurori.cmd.Parameters.AddWithValue("@ValAutore", Autore.ValAutore);

            pStrSQL = "UPDATE Autori SET " +
                        "CognAutore = @CognAutore, NomeAutore = @NomeAutore, DatNasAutore = @DatNasAutore, FotoAutore = @FotoAutore, ValAutore = @ValAutore" +
                        " WHERE IdAutore = @IdAutore";

            try
            {
                int Risultato = sqlAurori.eseguiNonQuery(pStrSQL, CommandType.Text);
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

            sqlAurori.cmd.Parameters.AddWithValue("@IdAutore", Autore.IdAutore);

            pStrSQL = "UPDATE Autori SET " +
                        " ValAutore = 'A' " +
                        " WHERE IdAutore = @IdAutore";

            try
            {
                int Risultato = sqlAurori.eseguiNonQuery(pStrSQL, CommandType.Text);
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

            sqlAurori.cmd.Parameters.AddWithValue("@IdAutore", Autore.IdAutore);

            pStrSQL = "UPDATE Autori SET " +
                        "ValAutore = '' " +
                        " WHERE IdAutore = @IdAutore";

            try
            {
                int Risultato = sqlAurori.eseguiNonQuery(pStrSQL, CommandType.Text);
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

            sqlAurori.cmd.Parameters.AddWithValue("@IdAutore", Autore.IdAutore);

            pStrSQL = "SELECT COUNT(*) FROM Autori " +
                        " WHERE IdAutore = @IdAutore";

            try
            {
                Risultato = sqlAurori.eseguiScalar(pStrSQL, CommandType.Text);
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
                        msgErrore = $"Il Autore [{Autore.IdAutore}] è già presente !!!";
                        controllo = false;
                    }

            }

            return controllo;
        }

        public List<clsAutori> elencoAutori()
        {
            listaAutori = new List<clsAutori>();

            pStrSQL = "SELECT *" +
                " FROM Autori" +
                " WHERE ValAutore = '' " +
                " ORDER BY IdAutore";

            caricaListaAutori();

            return listaAutori;
        }

        public List<clsAutori> elencoAutoriAnnullati()
        {
            listaAutori = new List<clsAutori>();

            pStrSQL = "SELECT * " +
                " FROM Autori " +
                " WHERE ValAutore = 'A' " +
                " ORDER BY IdAutore";

            caricaListaAutori();

            return listaAutori;
        }

        private void caricaListaAutori()
        {

            SqlDataReader dataReader;

            pErrore = false;

            try
            {
                dataReader = sqlAurori.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsAutori detAutore = new clsAutori();
                    detAutore.IdAutore = Convert.ToInt32(dataReader["IdAutore"]);
                    detAutore.CognAutore = dataReader["CognAutore"].ToString();
                    detAutore.NomeAutore = dataReader["NomeAutore"].ToString();
                    detAutore.DatNasAutore = (DateTime)dataReader["DatNasAutore"];
                    detAutore.FotoAutore = dataReader["FotoAutore"].ToString();
                    detAutore.ValAutore = Convert.ToChar(dataReader["ValAutore"]);
                    listaAutori.Add(detAutore);
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
                    sqlAurori.chiudiLettore();
                }
            }

        }

        public clsAutori datiAutore()
        {
            pErrore = false;
            clsAutori modAutore = new clsAutori();
            DataTable tabellaAutori = null;

            sqlAurori.cmd.Parameters.AddWithValue("@IdAutore", Autore.IdAutore);

            pStrSQL = "SELECT CognAutore, NomeAutore, DatNasAutore, FotoAutore, ValAutore FROM Autori " +
                        " WHERE IdAutore = @IdAutore";

            try
            {
                tabellaAutori = sqlAurori.eseguiQuery(pStrSQL, CommandType.Text);
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
                    modAutore.IdAutore = Autore.IdAutore;
                    modAutore.CognAutore = tabellaAutori.Rows[0].ItemArray[0].ToString();
                    modAutore.NomeAutore = tabellaAutori.Rows[0].ItemArray[1].ToString();
                    modAutore.DatNasAutore = (DateTime)tabellaAutori.Rows[0].ItemArray[2];
                    modAutore.FotoAutore = tabellaAutori.Rows[0].ItemArray[3].ToString();
                    modAutore.ValAutore = Convert.ToChar(tabellaAutori.Rows[0].ItemArray[4]);
                }
            }

            return modAutore;
        }
    }
}
