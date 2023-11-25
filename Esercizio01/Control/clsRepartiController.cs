using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using Esercizio01.Model;

namespace Esercizio01.Control
{
    class clsRepartiController
    {

        private adoNetSQL sqlReparto;
        private bool pErrore;
        private string pStrSQL;
        private List<clsReparto> listaReparti;

        public clsReparto Reparto;
        public string msgErrore;

        public clsRepartiController()
        {
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlReparto = new adoNetSQL(pathDB);
            Reparto = new clsReparto();
            Reparto.ValReparto = ' ';
            msgErrore = string.Empty;
        }

        public bool aggiungi()
        {
            pErrore = false;

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", Reparto.CodReparto);
            sqlReparto.cmd.Parameters.AddWithValue("@DeReparto", Reparto.DesReparto);
            sqlReparto.cmd.Parameters.AddWithValue("@VReparto", Reparto.ValReparto);

            pStrSQL = "INSERT INTO Reparti " +
                        " (CodReparto, DesReparto, ValReparto) " +
                        " VALUES(@CdReparto, @DeReparto, @VReparto)";

            try
            {
                int Risultato = sqlReparto.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Libro inserito correttamente !!!";
            }

            return pErrore;
        }

        public bool modifica()
        {
            pErrore = false;

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", Reparto.CodReparto);
            sqlReparto.cmd.Parameters.AddWithValue("@DeReparto", Reparto.DesReparto);
            sqlReparto.cmd.Parameters.AddWithValue("@VReparto", Reparto.ValReparto);

            pStrSQL = "UPDATE Reparti SET " +
                        "DesReparto = @DeReparto, ValReparto = @VReparto " +
                        "WHERE CodReparto = @CdReparto";

            try
            {
                int Risultato = sqlReparto.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Libro modificato correttamente !!!";
            }


            return pErrore;
        }

        public bool cancella()
        {
            pErrore = false;

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", Reparto.CodReparto);

            pStrSQL = "UPDATE Reparti SET " +
                        "ValReparto = 'A' " +
                        "WHERE CodReparto = @CdReparto";

            try
            {
                int Risultato = sqlReparto.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Libro cancellato correttamente !!!";
            }

            return pErrore;
        }

        public bool ripristina()
        {
            pErrore = false;

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", Reparto.CodReparto);

            pStrSQL = "UPDATE Reparti SET " +
                        "ValReparto = '' " +
                        "WHERE CodReparto = @CdReparto";

            try
            {
                int Risultato = sqlReparto.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = "ATTENZIONE !! " + ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Libro ripristina correttamente !!!";
            }

            return pErrore;
        }

        public bool chkReparto()
        {
            bool controllo = true;
            string Risultato = string.Empty;

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", Reparto.CodReparto);

            pStrSQL = "SELECT COUNT(*) FROM Reparti " +
                        "WHERE CodReparto = @CdReparto";

            try
            {
                Risultato = sqlReparto.eseguiScalar(pStrSQL, CommandType.Text);
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
                        msgErrore = $"Il Libro [{Reparto.CodReparto}] è già presente !!!";
                        controllo = false;
                    }

            }

            return controllo;
        }

        public List<clsReparto> elencoReparti()
        {
            listaReparti = new List<clsReparto>();

            pStrSQL = "SELECT * FROM Reparti WHERE ValReparto = '' ";

            caricaListaReparti();

            return listaReparti;
        }

        public List<clsReparto> elencoRepartiAnnullati()
        {
            listaReparti = new List<clsReparto>();

            pStrSQL = "SELECT * FROM Reparti WHERE ValReparto = 'A' ";

            caricaListaReparti();

            return listaReparti;
        }

        private void caricaListaReparti()
        {

            SqlDataReader dataReader;

            pErrore = false;

            try
            {
                dataReader = sqlReparto.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsReparto detReparto = new clsReparto();
                    detReparto.CodReparto = dataReader["CodReparto"].ToString();
                    detReparto.DesReparto = dataReader["DesReparto"].ToString();
                    detReparto.ValReparto = Convert.ToChar(dataReader["ValReparto"]);
                    listaReparti.Add(detReparto);
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
                    sqlReparto.chiudiLettore();
                }
            }

        }

        public clsReparto datiReparto()
        {
            pErrore = false;
            clsReparto modReparto = new clsReparto();
            DataTable tabellaReparti = null;

            sqlReparto.cmd.Parameters.AddWithValue("@CdReparto", Reparto.CodReparto);

            pStrSQL = "SELECT DesReparto, ValReparto FROM Reparti " +
                        "WHERE CodReparto = @CdReparto";

            try
            {
                tabellaReparti = sqlReparto.eseguiQuery(pStrSQL, CommandType.Text);
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
                    modReparto.CodReparto = Reparto.CodReparto;
                    modReparto.DesReparto = tabellaReparti.Rows[0].ItemArray[0].ToString();
                    modReparto.ValReparto = Convert.ToChar(tabellaReparti.Rows[0].ItemArray[1]);
                }
            }

            return modReparto;
        }

        public bool getReparto()
        {
            pErrore = false;

            sqlReparto.cmd.Parameters.AddWithValue("@DesReparto", Reparto.DesReparto);

            pStrSQL = "SELECT CodReparto FROM Reparti WHERE DesReparto = @DesReparto";

            try
            {
                string risultato = sqlReparto.eseguiScalar(pStrSQL, CommandType.Text);
                Reparto.CodReparto = risultato.ToString();
            }
            catch (Exception ex)
            {
                msgErrore = $"attenzione: - [{ex.Message}]";
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "Reparto trovato con successo";
            }

            return pErrore;
        }
    }
}
