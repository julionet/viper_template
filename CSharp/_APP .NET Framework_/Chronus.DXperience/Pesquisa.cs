using Chronus.Library;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;

namespace Chronus.DXperience
{
    public class Pesquisa
    {
        public static string GerarCondicaoFiltro(TextEdit textEditPesquisa, GridView gridView)
        {
            string condicao = "";
            foreach (GridColumn coluna in gridView.Columns)
            {
                if ((coluna.Visible || (!coluna.Visible && coluna.Tag != null && coluna.Tag.ToString() == "[PESQUISAR]") )&& (coluna.ColumnType != typeof(bool)))
                {
                    if (coluna.ColumnType == typeof(string))
                    {
                        if (string.IsNullOrWhiteSpace(condicao))
                            condicao += Funcoes.ConfigureStringCondition(textEditPesquisa.Text, coluna.FieldName);
                        else
                            condicao += " or " + Funcoes.ConfigureStringCondition(textEditPesquisa.Text, coluna.FieldName);
                    }
                    else if ((coluna.ColumnType == typeof(double)) || (coluna.ColumnType == typeof(double?)))
                    {
                        if (Funcoes.IsDouble(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += string.Format("({0} == {1})", coluna.FieldName, Funcoes.ComaToPoint(textEditPesquisa.Text));
                            else
                                condicao += " or " + string.Format("({0} == {1})", coluna.FieldName, Funcoes.ComaToPoint(textEditPesquisa.Text));
                        }
                    }
                    else if (coluna.ColumnType == typeof(DateTime))
                    {
                        if (Funcoes.IsDateTime(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureDateCondition(textEditPesquisa.Text, coluna.FieldName);
                            else
                                condicao += " or " + Funcoes.ConfigureDateCondition(textEditPesquisa.Text, coluna.FieldName);
                        }
                    }
                    else if (coluna.ColumnType == typeof(DateTime?))
                    {
                        if (Funcoes.IsDateTime(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureDateCondition(textEditPesquisa.Text, coluna.FieldName + ".Value");
                            else
                                condicao += " or " + Funcoes.ConfigureDateCondition(textEditPesquisa.Text, coluna.FieldName + ".Value");
                        }
                    }
                    else if (coluna.ColumnType == typeof(TimeSpan))
                    {
                        if (Funcoes.IsTimeSpan(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureTimeCondition(textEditPesquisa.Text, coluna.FieldName);
                            else
                                condicao += " or " + Funcoes.ConfigureTimeCondition(textEditPesquisa.Text, coluna.FieldName);
                        }
                    }
                    else if (coluna.ColumnType == typeof(TimeSpan?))
                    {
                        if (Funcoes.IsTimeSpan(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureTimeCondition(textEditPesquisa.Text, coluna.FieldName + ".Value");
                            else
                                condicao += " or " + Funcoes.ConfigureTimeCondition(textEditPesquisa.Text, coluna.FieldName + ".Value");
                        }
                    }
                    else if ((coluna.ColumnType == typeof(int)) || (coluna.ColumnType == typeof(int?)))
                    {
                        if (Funcoes.IsNumberInt32(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += string.Format("({0} == {1})", coluna.FieldName, textEditPesquisa.Text);
                            else
                                condicao += " or " + string.Format("({0} == {1})", coluna.FieldName, textEditPesquisa.Text);
                        }
                    }
                }
            }

            if (condicao != "")
                condicao = "(" + condicao + ")";

            return condicao;
        }

        public static string GerarCondicaoFiltroEspecifico(TextEdit textEditPesquisa, GridView gridView, string campo)
        {
            string condicao = "";
            foreach (GridColumn coluna in gridView.Columns.Where(p => p.FieldName == campo))
            {
                if ((coluna.Visible || (!coluna.Visible && coluna.Tag != null && coluna.Tag.ToString() == "[PESQUISAR]")) && (coluna.ColumnType != typeof(bool)))
                {
                    if (coluna.ColumnType == typeof(string))
                    {
                        if (string.IsNullOrWhiteSpace(condicao))
                            condicao += Funcoes.ConfigureStringCondition(textEditPesquisa.Text, coluna.FieldName);
                        else
                            condicao += " or " + Funcoes.ConfigureStringCondition(textEditPesquisa.Text, coluna.FieldName);
                    }
                    else if ((coluna.ColumnType == typeof(double)) || (coluna.ColumnType == typeof(double?)))
                    {
                        if (Funcoes.IsDouble(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += string.Format("({0} == {1})", coluna.FieldName, Funcoes.ComaToPoint(textEditPesquisa.Text));
                            else
                                condicao += " or " + string.Format("({0} == {1})", coluna.FieldName, Funcoes.ComaToPoint(textEditPesquisa.Text));
                        }
                    }
                    else if (coluna.ColumnType == typeof(DateTime))
                    {
                        if (Funcoes.IsDateTime(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureDateCondition(textEditPesquisa.Text, coluna.FieldName);
                            else
                                condicao += " or " + Funcoes.ConfigureDateCondition(textEditPesquisa.Text, coluna.FieldName);
                        }
                    }
                    else if (coluna.ColumnType == typeof(DateTime?))
                    {
                        if (Funcoes.IsDateTime(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureDateCondition(textEditPesquisa.Text, coluna.FieldName + ".Value");
                            else
                                condicao += " or " + Funcoes.ConfigureDateCondition(textEditPesquisa.Text, coluna.FieldName + ".Value");
                        }
                    }
                    else if (coluna.ColumnType == typeof(TimeSpan))
                    {
                        if (Funcoes.IsTimeSpan(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureTimeCondition(textEditPesquisa.Text, coluna.FieldName);
                            else
                                condicao += " or " + Funcoes.ConfigureTimeCondition(textEditPesquisa.Text, coluna.FieldName);
                        }
                    }
                    else if (coluna.ColumnType == typeof(TimeSpan?))
                    {
                        if (Funcoes.IsTimeSpan(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureTimeCondition(textEditPesquisa.Text, coluna.FieldName + ".Value");
                            else
                                condicao += " or " + Funcoes.ConfigureTimeCondition(textEditPesquisa.Text, coluna.FieldName + ".Value");
                        }
                    }
                    else if ((coluna.ColumnType == typeof(int)) || (coluna.ColumnType == typeof(int?)))
                    {
                        if (Funcoes.IsNumberInt32(textEditPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += string.Format("({0} == {1})", coluna.FieldName, textEditPesquisa.Text);
                            else
                                condicao += " or " + string.Format("({0} == {1})", coluna.FieldName, textEditPesquisa.Text);
                        }
                    }
                }
            }

            if (condicao != "")
                condicao = "(" + condicao + ")";

            return condicao;
        }
    }
}
