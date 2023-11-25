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
    class clsOfferteController
    {
        private adoNetSQL sqlOfferte;
        private bool pErrore;
        private string pStrSQL;
        private List<clsOfferte> listaOfferte;

        public clsOfferte Offerte;
        public string msgErrore;

        public clsOfferteController()
        {
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlOfferte = new adoNetSQL(pathDB);
            Offerte = new clsOfferte();
            Offerte.ValOfferta = ' ';
            msgErrore = string.Empty;
        }

        public bool aggiungi()
        {
            pErrore = false;

            sqlOfferte.cmd.Parameters.AddWithValue("@IdOfferta", Offerte.IdOfferta);
            sqlOfferte.cmd.Parameters.AddWithValue("@DesOfferta", Offerte.DesOfferta);
            sqlOfferte.cmd.Parameters.AddWithValue("@ScontoOfferta", Offerte.ScontoOfferta);
            sqlOfferte.cmd.Parameters.AddWithValue("@ValOfferta", Offerte.ValOfferta);

            pStrSQL = "INSERT INTO Offerte " +
                "(DesOfferta, ScontoOfferta, ValOfferta) " +
                "VALUES (@DesOfferta, @ScontoOfferta, @ValOfferta)";

            try
            {
                int Risultato = sqlOfferte.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Offerte inserito correttamente !!!";
            }

            return pErrore;
        }

        public bool modifica()
        {
            pErrore = false;
          
            sqlOfferte.cmd.Parameters.AddWithValue("@IdOfferta", Offerte.IdOfferta);
            sqlOfferte.cmd.Parameters.AddWithValue("@DesOfferta", Offerte.DesOfferta);
            sqlOfferte.cmd.Parameters.AddWithValue("@ScontoOfferta", Offerte.ScontoOfferta);
            sqlOfferte.cmd.Parameters.AddWithValue("@ValOfferta", Offerte.ValOfferta);

            pStrSQL = "UPDATE Offerte SET " +
                        "DesOfferta = @DesOfferta, ScontoOfferta = @ScontoOfferta, ValOfferta = @ValOfferta " +
                        "WHERE IdOfferta = @IdOfferta";

            try
            {
                int Risultato = sqlOfferte.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Offerte modificato correttamente !!!";
            }


            return pErrore;
        }

        public bool cancella()
        {
            pErrore = false;

            sqlOfferte.cmd.Parameters.AddWithValue("@IdOfferta", Offerte.IdOfferta);

            pStrSQL = "UPDATE Offerte SET " +
                        "ValOfferta = 'A' " +
                        "WHERE IdOfferta = @IdOfferta";

            try
            {
                int Risultato = sqlOfferte.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Offerte cancellato correttamente !!!";
            }

            return pErrore;
        }

        public bool ripristina()
        {
            pErrore = false;

            sqlOfferte.cmd.Parameters.AddWithValue("@IdOfferta", Offerte.IdOfferta);

            pStrSQL = "UPDATE Offerte SET " +
                        "ValOfferta = '' " +
                        "WHERE IdOfferta = @IdOfferta";

            try
            {
                int Risultato = sqlOfferte.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Offerte ripristina correttamente !!!";
            }

            return pErrore;
        }

        public bool chkOfferta()
        {
            bool controllo = true;
            string Risultato = string.Empty;

            sqlOfferte.cmd.Parameters.AddWithValue("@IdOfferta", Offerte.IdOfferta);

            pStrSQL = "SELECT COUNT(*) FROM Offerte " +
                        "WHERE IdOfferta = @IdOfferta";

            try
            {
                Risultato = sqlOfferte.eseguiScalar(pStrSQL, CommandType.Text);
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
                        msgErrore = $"Il Offerte [{Offerte.IdOfferta}] è già presente !!!";
                        controllo = false;
                    }

            }

            return controllo;
        }

        public List<clsOfferte> elencoOfferte()
        {
            listaOfferte = new List<clsOfferte>();

            pStrSQL = "SELECT *" +
                " FROM Offerte" +
                " WHERE ValOfferta = '' " +
                "ORDER BY IdOfferta";

            caricaListaOfferte();

            return listaOfferte;
        }

        public List<clsOfferte> elencoOfferteAnnullati()
        {
            listaOfferte = new List<clsOfferte>();

            pStrSQL = "SELECT * " +
                "FROM Offerte " +
                "WHERE ValOfferta = 'A' " +
                "ORDER BY IdOfferta";

            caricaListaOfferte();

            return listaOfferte;
        }

        private void caricaListaOfferte()
        {

            SqlDataReader dataReader;

            pErrore = false;

            try
            {
                dataReader = sqlOfferte.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsOfferte detOfferta = new clsOfferte();
                    detOfferta.IdOfferta = Convert.ToInt32(dataReader["IdOfferta"]);
                    detOfferta.DesOfferta = dataReader["DesOfferta"].ToString();
                    detOfferta.ScontoOfferta = Convert.ToInt32(dataReader["ScontoOfferta"]);
                    detOfferta.ValOfferta = Convert.ToChar(dataReader["ValOfferta"]);
                    listaOfferte.Add(detOfferta);
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
                    sqlOfferte.chiudiLettore();
                }
            }

        }

        public clsOfferte datiOfferta()
        {
            pErrore = false;
            clsOfferte modOfferta = new clsOfferte();
            DataTable tabellaOfferta = null;

            sqlOfferte.cmd.Parameters.AddWithValue("@IdOfferta", Offerte.IdOfferta);

            pStrSQL = "SELECT DesOfferta, ScontoOfferta, ValOfferta FROM Offerte " +
                        "WHERE IdOfferta = @IdOfferta";

            try
            {
                tabellaOfferta = sqlOfferte.eseguiQuery(pStrSQL, CommandType.Text);
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
                    modOfferta.IdOfferta = Offerte.IdOfferta;
                    modOfferta.DesOfferta = tabellaOfferta.Rows[0].ItemArray[0].ToString();
                    modOfferta.ScontoOfferta = Convert.ToInt32(tabellaOfferta.Rows[0].ItemArray[1]);
                    modOfferta.ValOfferta = Convert.ToChar(tabellaOfferta.Rows[0].ItemArray[2]);
                }
            }

            return modOfferta;
        }
        public bool getOfferte()
        {
            pErrore = false;

            sqlOfferte.cmd.Parameters.AddWithValue("@DesOfferta", Offerte.DesOfferta);

            pStrSQL = "SELECT IdOfferta FROM Offerte WHERE DesOfferta = @DesOfferta";

            try
            {
                string risultato = sqlOfferte.eseguiScalar(pStrSQL, CommandType.Text);
                Offerte.IdOfferta = Convert.ToInt32(risultato);

            }
            catch (Exception ex)
            {
                msgErrore = $"attenzione: - [{ex.Message}]";
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Offerta trovato con successo";
            }

            return pErrore;
        }
        public bool getOffertaId()
        {
            pErrore = false;

            sqlOfferte.cmd.Parameters.AddWithValue("@IdOfferta", Offerte.IdOfferta);

            pStrSQL = "SELECT DesOfferta FROM Offerte WHERE IdOfferta = @IdOfferta";

            try
            {
                string risultato = sqlOfferte.eseguiScalar(pStrSQL, CommandType.Text);
                Offerte.DesOfferta = risultato;
            }
            catch (Exception ex)
            {
                msgErrore = $"attenzione: - [{ex.Message}]";
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "offerta trovata con successo";
            }

            return pErrore;
        }
    }
}
