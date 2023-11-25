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
    class clsLibroController
    {
        private adoNetSQL sqlNLibro;
        private bool pErrore;
        private string pStrSQL;
        private List<clsLibri> listaNLibri;

        public clsLibri Libro;
        public string msgErrore;

        public clsLibroController()
        {
            string pathDB = Application.StartupPath + "\\CatalogoLibri.mdf";
            sqlNLibro = new adoNetSQL(pathDB);
            Libro = new clsLibri();
            Libro.ValLibro = ' ';
            msgErrore = string.Empty;
        }
        public bool aggiungi()
        {
            pErrore = false;

            sqlNLibro.cmd.Parameters.AddWithValue("@IdLibro", Libro.IdLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@TitoloLibro", Libro.TitoloLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@ImgLibro", Libro.ImgLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@PrezzoLibro", Libro.PrezzoLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@DataLibro", Libro.DataLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@NPagineLibro", Libro.NPagineLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@CodRepLibro", Libro.CodRepLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@IdOffLibro", Libro.IdOffLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@IdEdiLibro", Libro.IdEdiLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@ValLibro", Libro.ValLibro);


            pStrSQL = "INSERT INTO Libri" +
                " (TitoloLibro, ImgLibro, PrezzoLibro, DataLibro, NPagineLibro, CodRepLibro, IdOffLibro, IdEdiLibro, ValLibro) " +
                        " VALUES (@TitoloLibro, @ImgLibro, @PrezzoLibro, @DataLibro, @NPagineLibro, @CodRepLibro, @IdOffLibro, @IdEdiLibro, @ValLibro)";

            try
            {
                int Risultato = sqlNLibro.eseguiNonQuery(pStrSQL, CommandType.Text);
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
        public List<clsLibri> elencoLibri()
        {
            listaNLibri = new List<clsLibri>();

            pStrSQL = "SELECT *" +
                " FROM Libri" +
                " WHERE ValLibro = '' " +
                "ORDER BY IdLibro";

            caricaListaLibri();

            return listaNLibri;
        }
        public List<clsLibri> elencoLibriAnnullati()
        {
            listaNLibri = new List<clsLibri>();

            pStrSQL = "SELECT *" +
                " FROM Libri" +
                " WHERE ValLibro = 'A' " +
                "ORDER BY IdLibro";

            caricaListaLibri();

            return listaNLibri;
        }
        public List<clsLibri> elencoLibriRicercato()
        {
            listaNLibri = new List<clsLibri>();

            sqlNLibro.cmd.Parameters.AddWithValue("@CodRepLibro", Libro.CodRepLibro);

            pStrSQL = "SELECT * FROM Libri Where CodRepLibro = @CodRepLibro";

            caricaListaLibri();

            return listaNLibri;
        }

        public List<clsLibri> elencoLibriRicercatoOfferta()
        {
            listaNLibri = new List<clsLibri>();

            sqlNLibro.cmd.Parameters.AddWithValue("@IdOffLibro", Libro.IdOffLibro);

            pStrSQL = "SELECT * FROM Libri Where IdOffLibro = @IdOffLibro";

            caricaListaLibri();

            return listaNLibri;
        }
        private void caricaListaLibri()
        {

            SqlDataReader dataReader;

            pErrore = false;

            try
            {
                dataReader = sqlNLibro.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clsLibri detLibro = new clsLibri();
                    detLibro.IdLibro = Convert.ToInt32(dataReader["IdLibro"]);
                    detLibro.TitoloLibro = Convert.ToString(dataReader["TitoloLibro"]);
                    detLibro.ImgLibro = Convert.ToString(dataReader["ImgLibro"]);
                    detLibro.PrezzoLibro = Convert.ToInt32(dataReader["PrezzoLibro"]);
                    detLibro.DataLibro = Convert.ToDateTime(dataReader["DataLibro"]);
                    detLibro.NPagineLibro = Convert.ToInt32(dataReader["NPagineLibro"]);
                    detLibro.CodRepLibro = Convert.ToString(dataReader["CodRepLibro"]);
                    detLibro.IdOffLibro = Convert.ToInt32(dataReader["IdOffLibro"]);
                    detLibro.IdEdiLibro = Convert.ToInt32(dataReader["IdEdiLibro"]);
                    detLibro.ValLibro = Convert.ToChar(dataReader["ValLibro"]);
                    listaNLibri.Add(detLibro);
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
                    sqlNLibro.chiudiLettore();
                }
            }

        }
        public bool modifica()
        {
            pErrore = false;

            sqlNLibro.cmd.Parameters.AddWithValue("@IdLibro", Libro.IdLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@TitoloLibro", Libro.TitoloLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@ImgLibro", Libro.ImgLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@PrezzoLibro", Libro.PrezzoLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@DataLibro", Libro.DataLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@NPagineLibro", Libro.NPagineLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@CodRepLibro", Libro.CodRepLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@IdOffLibro", Libro.IdOffLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@IdEdiLibro", Libro.IdEdiLibro);
            sqlNLibro.cmd.Parameters.AddWithValue("@ValLibro", Libro.ValLibro);

            pStrSQL = "UPDATE Libri SET " +
                "TitoloLibro = @TitoloLibro, ImgLibro = @ImgLibro," +
                " PrezzoLibro = @PrezzoLibro, DataLibro = @DataLibro, " +
                "NPagineLibro = @NPagineLibro, CodRepLibro = @CodRepLibro, " +
                "IdOffLibro = @IdOffLibro, IdEdiLibro = @IdEdiLibro," +
                " ValLibro = @ValLibro " +
                "WHERE IdLibro = @IdLibro";

            try
            {
                int risultato = sqlNLibro.eseguiNonQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = $"attenzione: - [{ex.Message}]";
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgErrore = "libro modificato con successo";
            }

            return pErrore; 
        }
        public bool chkLibro()
        {
            bool controllo = true;
            string risultato = string.Empty;

            sqlNLibro.cmd.Parameters.AddWithValue("@IdLibro", Libro.IdEdiLibro);

            pStrSQL = "SELECT COUNT(*) FROM Libri WHERE IdLibro = @IdLibro";

            try
            {
                risultato = sqlNLibro.eseguiScalar(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = $"attenzione: - [{ex.Message}]";
                controllo = false;
            }
            finally
            {
                if (controllo)
                {
                    if (Convert.ToInt32(risultato) != 0)
                    {
                        msgErrore = $"libro già presente - [{Libro.IdLibro}]";
                        controllo = false;
                    }
                }
            }

            return controllo;
        }
        public clsLibri datiLibro()
        {
            pErrore = false;
            clsLibri modLibro = new clsLibri();
            DataTable tabellaLibri = null;

            sqlNLibro.cmd.Parameters.AddWithValue("@IdLibro", Libro.IdLibro);

            pStrSQL = "SELECT TitoloLibro, ImgLibro, PrezzoLibro, DataLibro, NPagineLibro, CodRepLibro, IdOffLibro, IdEdiLibro, ValLibro FROM Libri WHERE IdLibro = @IdLibro";

            try
            {
                tabellaLibri = sqlNLibro.eseguiQuery(pStrSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                msgErrore = $"attenzione: - [{ex.Message}]";
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                {
                    modLibro.IdLibro = Libro.IdLibro;
                    modLibro.TitoloLibro = tabellaLibri.Rows[0].ItemArray[0].ToString();
                    modLibro.ImgLibro = tabellaLibri.Rows[0].ItemArray[1].ToString();
                    modLibro.PrezzoLibro = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[2]);
                    modLibro.DataLibro = Convert.ToDateTime(tabellaLibri.Rows[0].ItemArray[3]);
                    modLibro.NPagineLibro = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[4]);
                    modLibro.CodRepLibro = tabellaLibri.Rows[0].ItemArray[5].ToString();
                    modLibro.IdOffLibro = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[6]);
                    modLibro.IdEdiLibro = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[7]);
                    modLibro.ValLibro = Convert.ToChar(tabellaLibri.Rows[0].ItemArray[8]);
                }
            }

            return modLibro;
        }


    }
}
