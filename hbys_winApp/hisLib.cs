using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hbys_winApp
{
    class hisLib
    {
        string database_connection = "server=TAVLI\\SQLEXPRESS; database=hbys; user id=sa; pwd=blitz";
        SqlConnection sql_connection =  null;

        public hisLib()
        {
            sql_connection = new SqlConnection(database_connection);
        }
        /////////////////////////////////Patient Block////////////////////////////////////////////////
        public DataSet patientList()
        {
            DataSet patientListDataset = new DataSet();            
            string sql = "select * from patient";
            SqlDataAdapter patientListAdapter = new SqlDataAdapter(sql, sql_connection);            
            sql_connection.Open();
            patientListAdapter.Fill(patientListDataset);
            sql_connection.Close();
            return patientListDataset; 
        }

        public DataSet getSinglePatient(int PatientNo)
        {
            DataSet getSinglePatientDataSet = new DataSet();
            string getSinglePatientSql = "SELECT * FROM Patient WHERE PatientNo ="+PatientNo.ToString();
            SqlDataAdapter getSinglePatientDataAdapter = new SqlDataAdapter(getSinglePatientSql , sql_connection);
            sql_connection.Open();
            getSinglePatientDataAdapter.Fill(getSinglePatientDataSet);
            sql_connection.Close();
            return getSinglePatientDataSet;
        }

        public DataSet showPatientinComboBox(int PatientNo)
        {
            string patientSql = "";
            if (PatientNo == 0)
                patientSql = "select FName , Sname, TCNo from Patient";
            else
                patientSql = "select FName , Sname, TCNo from Patient where PatientNo ="+PatientNo.ToString();
            DataSet patientDataSet = new DataSet();
            SqlDataAdapter patientDataAdapter = new SqlDataAdapter(patientSql , sql_connection);
            sql_connection.Open();
            patientDataAdapter.Fill(patientDataSet);
            sql_connection.Close();
            return patientDataSet;
        }

        public string addPatientDatas(string Fname, string Lname , string TCno)
        {

            try
            {
                string addPatientDatasSql = "INSERT INTO Patient(FName ,Sname ,TCNo) VALUES (@Fn, @Ln ,@TC)";
                SqlCommand addPatientDatasSqlCommand = new SqlCommand(addPatientDatasSql, sql_connection);
                addPatientDatasSqlCommand.Parameters.AddWithValue("@Fn", Fname);
                addPatientDatasSqlCommand.Parameters.AddWithValue("@Ln", Lname);
                addPatientDatasSqlCommand.Parameters.AddWithValue("@TC", TCno);
                sql_connection.Open();
                addPatientDatasSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "addPatientDatas";
            }
            catch (Exception addPatientDatasException)
            {
                return addPatientDatasException.Message;
            }//end catch
        }//end patientAdd

        public string updatePatientDatas(string FirstName, string LastName, string TCNo, int PatientNo)
        {
            try
            {
                string updatePatientDatasSql = "UPDATE Patient SET FName=@FName, SName=@LName , TCNo=@TNo WHERE PatientNo=@PNo";
                SqlCommand updatePatientDatasSqlCommand = new SqlCommand(updatePatientDatasSql , sql_connection);
                updatePatientDatasSqlCommand.Parameters.AddWithValue("@FName",FirstName);
                updatePatientDatasSqlCommand.Parameters.AddWithValue("@LName",LastName);
                updatePatientDatasSqlCommand.Parameters.AddWithValue("@TNo",TCNo);
                updatePatientDatasSqlCommand.Parameters.AddWithValue("@PNo",PatientNo);
                sql_connection.Open();
                updatePatientDatasSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "updatePatientDatas";
            }catch(Exception updatePatientDatasException){
                return updatePatientDatasException.Message;
            }// end catch
        }//end updatePatientDatas




        public string deletePatientDatas(int PatientNo)
        {
            try
            {
                //string deletePatientDatasSql = "DELETE Patient Where PatientNo=@PNo";
                SqlCommand deletePatientDatasSqlCommand = new SqlCommand("deletePatient", sql_connection);
                deletePatientDatasSqlCommand.CommandType = CommandType.StoredProcedure;

                deletePatientDatasSqlCommand.Parameters.AddWithValue("@patientNo", PatientNo);
                sql_connection.Open();
                deletePatientDatasSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "deletePatientDatas";
            }
            catch (Exception deletePatientDatasException)
            {
                return deletePatientDatasException.Message;
            }
        }//end deletePatientDatas


        public string deletePatientDatasSQL(int PatientNo)
        {
            try
            {
                string deletePatientDatasSql = "DELETE Patient Where PatientNo=@PNo";
                SqlCommand deletePatientDatasSqlCommand = new SqlCommand(deletePatientDatasSql , sql_connection);
                deletePatientDatasSqlCommand.Parameters.AddWithValue("@PNo",PatientNo);
                sql_connection.Open();
                deletePatientDatasSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "deletePatientDatas";
            }
            catch (Exception deletePatientDatasException)
            {
                return deletePatientDatasException.Message;
            }
        }//end deletePatientDatas
                  /////////////////////////////////Patient Block////////////////////////////////////////////////
                 /////////////////////////////////Service Block////////////////////////////////////////////////
        public DataSet showServiceNames()
        {
            string sql = "select * from Service";
            DataSet ds = new DataSet();
            SqlDataAdapter sDA = new SqlDataAdapter(sql ,sql_connection);
            sql_connection.Open();
            sDA.Fill(ds);
            sql_connection.Close();
            return ds;
        }

        public DataSet getSingleServiceName(int ServiceNo)
        {
            string sql = "select * from Service where ServiceNo =" + ServiceNo.ToString(); 
            DataSet ds = new DataSet();
            SqlDataAdapter sDA = new SqlDataAdapter(sql, sql_connection);
            sql_connection.Open();
            sDA.Fill(ds);
            sql_connection.Close();
            return ds;
        }

        public string addServiceName(string ServiceName)
        {
            string sql = " Insert Into Service(ServiceName) Values(@ServiceName)";
            SqlCommand sc = new SqlCommand(sql, sql_connection);
            sc.Parameters.AddWithValue("@ServiceName",ServiceName);
            sql_connection.Open();
            sc.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }

        public string updateServiceName(int ServiceNo , string ServiceName)
        {
            try
            {
                string strSqlComm = "UPDATE Service SET ServiceName=@ServiceName WHERE ServiceNo = @ServiceNo";
                SqlCommand objectSqlCommand = new SqlCommand(strSqlComm, sql_connection);
                objectSqlCommand.Parameters.AddWithValue("@ServiceName", ServiceName);
                objectSqlCommand.Parameters.AddWithValue("@ServiceNo", ServiceNo);
                sql_connection.Open();
                objectSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "1";
            }
            catch (Exception addDrugNameException)
            {
                return addDrugNameException.Message;
            }
        }//end addDrugName

        public string deleteServiceName(int ServiceNo)
        {
            string sql = "Delete Service Where ServiceNo =@ServiceNo";
            SqlCommand sc = new SqlCommand(sql , sql_connection);
            sc.Parameters.AddWithValue("@ServiceNo" , ServiceNo);
            sql_connection.Open();
            sc.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }

       
              /////////////////////////////////Service Block////////////////////////////////////////////////
             /////////////////////////////////Drug Block////////////////////////////////////////////////
        public DataSet DrugList()
        {
            DataSet DrugListDataSet = new DataSet();
            string getDataFromDrug = "select * from Drug";
            SqlDataAdapter DrugListDataAdapter = new SqlDataAdapter(getDataFromDrug,sql_connection);
            sql_connection.Open();
            DrugListDataAdapter.Fill(DrugListDataSet);
            sql_connection.Close();
            return DrugListDataSet;
        }//end DrugList


        public DataSet DrugListByRecipeNo(int recipeNo)
        {
            DataSet DrugListDataSet = new DataSet();
            string getDataFromDrug = "select D.* from RecipeDetail RD , Drug D where RD.DrugNo = D.DrugNo and RD.RecipeNo = "+recipeNo.ToString();
            SqlDataAdapter DrugListDataAdapter = new SqlDataAdapter(getDataFromDrug, sql_connection);
            sql_connection.Open();
            DrugListDataAdapter.Fill(DrugListDataSet);
            sql_connection.Close();
            return DrugListDataSet;
        }//end DrugList


        public DataSet getDrugSingle(int DrugNo)
        {
            DataSet DrugListDataSet = new DataSet();
            string getDataFromDrug = "select * from Drug where DrugNo=  "+DrugNo.ToString();
            SqlDataAdapter DrugListDataAdapter = new SqlDataAdapter(getDataFromDrug, sql_connection);
            sql_connection.Open();
            DrugListDataAdapter.Fill(DrugListDataSet);
            sql_connection.Close();
            return DrugListDataSet;
        }//end DrugList


        public string addDrugName(string DrugName)
        {
            try
            {
                string addDrugNameSql = "INSERT INTO Drug(DrugName) VALUES(@Drug)";
                SqlCommand addDrugNameSqlCommand = new SqlCommand(addDrugNameSql, sql_connection);
                addDrugNameSqlCommand.Parameters.AddWithValue("@Drug", DrugName);
                sql_connection.Open();
                addDrugNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "drugNameAdded";
            }
            catch (Exception addDrugNameException)
            {
                return addDrugNameException.Message;
            }
        }//end addDrugName

        public string updateDrugName(int DrugNo , string DrugName)
        {
            try
            {
                string addDrugNameSql = "UPDATE Drug SET DrugName=@DrugName WHERE DrugNo = @DrugNo";
                SqlCommand addDrugNameSqlCommand = new SqlCommand(addDrugNameSql, sql_connection);
                addDrugNameSqlCommand.Parameters.AddWithValue("@DrugName", DrugName);
                addDrugNameSqlCommand.Parameters.AddWithValue("@DrugNo", DrugNo);
                sql_connection.Open();
                addDrugNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "drugNameAdded";
            }
            catch (Exception addDrugNameException)
            {
                return addDrugNameException.Message;
            }
        }//end addDrugName

        public string deleteDrugName(int DrugNo)
        {
            try
            {
                string addDrugNameSql = "DELETE Drug WHERE DrugNo = @DrugNo";
                SqlCommand addDrugNameSqlCommand = new SqlCommand(addDrugNameSql, sql_connection);
                addDrugNameSqlCommand.Parameters.AddWithValue("@DrugNo", DrugNo);
                sql_connection.Open();
                addDrugNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "drugNameDeleted";
            }
            catch (Exception addDrugNameException)
            {
                return addDrugNameException.Message;
            }
        }//end addDrugName


        public string addDrug2Recipe(int RecipeNo, int DrugNo)
        {
            string recipeSql = " insert into RecipeDetail ( RecipeNo, DrugNo) values ( @RecipeNo, @DrugNo ) ";            
            SqlCommand recipeSqlCommand = new SqlCommand(recipeSql, sql_connection);
            recipeSqlCommand.Parameters.AddWithValue("@RecipeNo", RecipeNo);
            recipeSqlCommand.Parameters.AddWithValue("@DrugNo", DrugNo);            
            sql_connection.Open();
            recipeSqlCommand.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }


        /////////////////////////////////Drug Block////////////////////////////////////////////////
        /////////////////////////////////Survey Block////////////////////////////////////////////////

        public DataSet showSurveyList()
        {
            DataSet showSurveyListDataSet = new DataSet();
            string showSurveySql = "select * from Survey";
            SqlDataAdapter showSurveyListDataAdapter = new SqlDataAdapter(showSurveySql,sql_connection);
            sql_connection.Open();
            showSurveyListDataAdapter.Fill(showSurveyListDataSet);
            sql_connection.Close();
            return showSurveyListDataSet;
        }


        public DataSet showSurveyListByExamNo(int ExamNo)
        {
            DataSet showSurveyListDataSet = new DataSet();
            string showSurveySql = "select S.* from Survey S , ExamSurvey ES , Examination E "+ 
                " where S.SurveyNo = ES.SurveyNo  and ES.ExaminationNo = E.ExaminationNo and E.ExaminationNo =   "+ ExamNo.ToString();
            SqlDataAdapter showSurveyListDataAdapter = new SqlDataAdapter(showSurveySql, sql_connection);
            sql_connection.Open();
            showSurveyListDataAdapter.Fill(showSurveyListDataSet);
            sql_connection.Close();
            return showSurveyListDataSet;
        }

        public DataSet getSingleSurveyList(int SurveyNo)
        {
            string getSingleSurveyListSql = "SELECT * FROM Survey WHERE SurveyNo ="+SurveyNo.ToString();
            DataSet getSingleSurveyListDataSet = new DataSet();
            SqlDataAdapter getSinglSurveyListDataAdapter = new SqlDataAdapter(getSingleSurveyListSql , sql_connection);
            sql_connection.Open();
            getSinglSurveyListDataAdapter.Fill(getSingleSurveyListDataSet);
            sql_connection.Close();
            return getSingleSurveyListDataSet;
        }

        public string addSurveyName(string SurveyName)
        {
            try
            {
                string addSurveyNameSql = "INSERT INTO Survey(SurveyName) Values(@Survey)";
                SqlCommand addSurveyNameSqlCommand = new SqlCommand(addSurveyNameSql, sql_connection);
                addSurveyNameSqlCommand.Parameters.AddWithValue("@Survey", SurveyName);
                sql_connection.Open();
                addSurveyNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "addSurveyName";
            }
            catch (Exception addSurveyNameException)
            {
                return addSurveyNameException.Message;
            }
        }//end addSurveyName

        public string updateSurveyName(string SurveyName, int SurveyNo)
        {
            try
            {
                string updateSurveyNameSql = "UPDATE Survey SET SurveyName=@SurveyName WHERE SurveyNo=@SurveyNo";
                SqlCommand updateSurveyNameSqlCommand = new SqlCommand(updateSurveyNameSql , sql_connection);
                updateSurveyNameSqlCommand.Parameters.AddWithValue("@SurveyName",SurveyName);
                updateSurveyNameSqlCommand.Parameters.AddWithValue("@SurveyNo",SurveyNo);
                sql_connection.Open();
                updateSurveyNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "updateSurveyName";
            }
            catch (Exception updateSurveyNameException)
            {
                return updateSurveyNameException.Message;
            }
        }//end updateSurveyName

        public string deleteSurveyName(int SurveyNo)
        {
            try
            {
                string deleteSurveyName = "DELETE Survey WHERE SurveyNo=@SNo ";
                SqlCommand deleteSurveyNameSqlCommand = new SqlCommand(deleteSurveyName, sql_connection);
                deleteSurveyNameSqlCommand.Parameters.AddWithValue("@SNo", SurveyNo);
                sql_connection.Open();
                deleteSurveyNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "deleteSurveyName";
            }catch(Exception delex){
                return delex.Message;
            }
        }
        /////////////////////////////////Survey Block////////////////////////////////////////////////
        /////////////////////////////////Diagnosis Block////////////////////////////////////////////////
        public DataSet showDiagnosisList()
        {
            DataSet showDiagnosisListDataSet = new DataSet();
            string showDiagnosisListSql = "select D.DiagNo as [Diagnosis No], D.DiagName as [Diagnosis Name] from Diagnosis D";
            SqlDataAdapter showDiagnosisDataAdapter = new SqlDataAdapter(showDiagnosisListSql , sql_connection);
            sql_connection.Open();
            showDiagnosisDataAdapter.Fill(showDiagnosisListDataSet);
            sql_connection.Close();
            return showDiagnosisListDataSet;
        }


        public DataSet showDiagnosisListByExamNo(int examNo)
        {
            DataSet showDiagnosisListDataSet = new DataSet();
            string showDiagnosisListSql = "select D.DiagNo as [Diagnosis No], D.DiagName as [Diagnosis Name] from Diagnosis D , Examination E, ExamDiag Ed " +
                        "  where  E.ExaminationNo =" + examNo.ToString() +
                        "   and E.ExaminationNo = ED.ExaminationNo and ED.DiagNo = D.DiagNo ";
            SqlDataAdapter showDiagnosisDataAdapter = new SqlDataAdapter(showDiagnosisListSql, sql_connection);
            sql_connection.Open();
            showDiagnosisDataAdapter.Fill(showDiagnosisListDataSet);
            sql_connection.Close();
            return showDiagnosisListDataSet;
        }

        public string addDiagnosisName(string DiagName)
        {
            try
            {
                string addDiagnosisNameSql = "INSERT INTO Diagnosis(DiagName) VALUES(@Diag)";
                SqlCommand addDiagnosisNameSqlCommand = new SqlCommand(addDiagnosisNameSql, sql_connection);
                addDiagnosisNameSqlCommand.Parameters.AddWithValue("@Diag", DiagName);
                sql_connection.Open();
                addDiagnosisNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "addDiagnosisName";
            }
            catch (Exception addex)
            {
                return addex.Message;
            }
        }//end addDiagnosisName

        public string updateDiagnosisName(int DiagNo , string DiagName)
        {
            try
            {
                string addDiagnosisNameSql = "UPDATE Drug SET DiagName=@DiagName WHERE DiagNo=@DiagNo";
                SqlCommand updateDiagnosisNameSqlCommand = new SqlCommand(addDiagnosisNameSql, sql_connection);
                updateDiagnosisNameSqlCommand.Parameters.AddWithValue("@DiagName", DiagName);
                updateDiagnosisNameSqlCommand.Parameters.AddWithValue("@DiagNo", DiagNo);
                sql_connection.Open();
                updateDiagnosisNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "updateDiagnosisName";
            }
            catch (Exception upex)
            {
                return upex.Message;
            }
        }//end addDiagnosisName

        public string deleteDiagName(int DiagNo)
        {
            try
            {
                string deleteDiagNameSql = "DELETE Diag Where DiagNo = @DiagNo";
                SqlCommand deleteDiagNameSqlCommand = new SqlCommand(deleteDiagNameSql, sql_connection) ;
                deleteDiagNameSqlCommand.Parameters.AddWithValue("@DiagNo",DiagNo);
                sql_connection.Open();
                deleteDiagNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "diagNameDeleted";
            }
            catch(Exception deleteDiagNameException)
            {
                return deleteDiagNameException.Message;
            }
        }

        public DataSet getDiagSingle(int DiagNo)
        {
            DataSet DiagListDataSet = new DataSet();
            string getDataFromDrug = "select * from Diagnosis where DiagNo ="+DiagNo.ToString();
            SqlDataAdapter DrugListDataAdapter = new SqlDataAdapter(getDataFromDrug, sql_connection);
            sql_connection.Open();
            DrugListDataAdapter.Fill(DiagListDataSet);
            sql_connection.Close();
            return DiagListDataSet;
        }//end DrugList

        /////////////////////////////////Diagnosis Block////////////////////////////////////////////////
        /////////////////////////////////Title Block////////////////////////////////////////////////
        public DataSet showTitleList()
        {
            DataSet showTitleListDataSet = new DataSet();
            string showTitleListDataSetSql = "select * from Title";
            SqlDataAdapter showTitleListDataAdapter = new SqlDataAdapter(showTitleListDataSetSql , sql_connection);
            sql_connection.Open();
            showTitleListDataAdapter.Fill(showTitleListDataSet);
            sql_connection.Close();
            return showTitleListDataSet;
        }

        public DataSet getSingleTitleName(int TitleNo)
        {
            DataSet getSingleTitleNameDataSet = new DataSet();
            string getSingleTitleSql = "SELECT * FROM Title WHERE TitleNo ="+TitleNo.ToString();
            SqlDataAdapter getSingleTitleNameDataAdapter = new SqlDataAdapter(getSingleTitleSql , sql_connection);
            sql_connection.Open();
            getSingleTitleNameDataAdapter.Fill(getSingleTitleNameDataSet);
            sql_connection.Close();
            return getSingleTitleNameDataSet;
        }

        public string addTitleName(string TitleName)
        {
            try
            {
                string addTitleNameSql = "INSERT INTO Title(TitleName) VALUES(@Title)";
                SqlCommand addTitleNameSqlCommand = new SqlCommand(addTitleNameSql, sql_connection);
                addTitleNameSqlCommand.Parameters.AddWithValue("@Title", TitleName);
                sql_connection.Open();
                addTitleNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "addTitleName";
            }
            catch (Exception addTitleNameException)
            {
                return addTitleNameException.Message;
            }
        }//end addTitleName

        public string updateTitleName(string TitleName, int TitleNo)
        {
            try
            {
                string updateTitleNameSql = "UPDATE Title SET TitleName=@TitleName WHERE TitleNo=@TitleNo";
                SqlCommand updateTitleNameSqlCommand = new SqlCommand(updateTitleNameSql , sql_connection);
                updateTitleNameSqlCommand.Parameters.AddWithValue("@TitleName",TitleName);
                updateTitleNameSqlCommand.Parameters.AddWithValue("@TitleNo",TitleNo);
                sql_connection.Open();
                updateTitleNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "updateTitleName";
            }catch(Exception updateTitleNameException){
                return updateTitleNameException.Message;
            }
        }//end updateTitleName

        public string deleteTitleName(int TitleNo)
        {
            try
            {
                string deleteTitleNameSql = "DELETE Title WHERE TitleNo=@TNo";
                SqlCommand deleteTitleNameSqlCommand = new SqlCommand(deleteTitleNameSql, sql_connection);
                deleteTitleNameSqlCommand.Parameters.AddWithValue(deleteTitleNameSql, sql_connection);
                sql_connection.Open();
                deleteTitleNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "deleteTitleName";
            }
            catch (Exception delex)
            {
                return delex.Message;

            }
        }
        /////////////////////////////////Title Block////////////////////////////////////////////////
        /////////////////////////////////Establishment Block////////////////////////////////////////////////
        public DataSet showEstablishment()
        {
            DataSet showEstablishmentDataSet = new DataSet();
            string showEstablishmentsQL = "select * from Establishment";
            SqlDataAdapter showEstablishmentDataAdapter = new SqlDataAdapter(showEstablishmentsQL , sql_connection);
            sql_connection.Open();
            showEstablishmentDataAdapter.Fill(showEstablishmentDataSet);
            sql_connection.Close();
            return showEstablishmentDataSet;
        }

        public DataSet getSingleEstablishmentName(int EstablishmentNo)
        {
            string getEstaSql = "SELECT * FROM Establishment WHERE EstablishmentNo ="+EstablishmentNo.ToString();
            DataSet getEstaDataSet = new DataSet();
            SqlDataAdapter getEstaDataAdapter = new SqlDataAdapter(getEstaSql , sql_connection);
            sql_connection.Open();
            getEstaDataAdapter.Fill(getEstaDataSet);
            sql_connection.Close();
            return getEstaDataSet;
        }

        public string addEstablishmentName(string EstablishmentName)
        {
            try
            {
                string addEstablishmentName = "INSERT INTO Establishment(EstablishmentName) VALUES(@En)";
                SqlCommand addEstablishmentNameSqlCommand = new SqlCommand(addEstablishmentName, sql_connection);
                addEstablishmentNameSqlCommand.Parameters.AddWithValue("@En", EstablishmentName);
                sql_connection.Open();
                addEstablishmentNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "addEstablishmentName";
            }
            catch (Exception addEstablishmentNameException)
            {
                return addEstablishmentNameException.Message;
            }
        }//end addEstablishmentName

        public string updateEstablishmentName(string EstablishmentName, int EstablishmentNo)
        {
            try
            {
                string updateEstablishmentNameSql = "UPDATE Establishment SET EstablishmentName=@EstablishmentName where EstablishmentNo=@EstablishmentNo";
                SqlCommand updateEstablishmentNameSqlCommand = new SqlCommand(updateEstablishmentNameSql , sql_connection);
                updateEstablishmentNameSqlCommand.Parameters.AddWithValue("@EstablishmentName",EstablishmentName);
                updateEstablishmentNameSqlCommand.Parameters.AddWithValue("@EstablishmentNo",EstablishmentNo);
                sql_connection.Open();
                updateEstablishmentNameSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "updateEsta";
            }
            catch(Exception updateEstablishmentNameException)
            {
                return updateEstablishmentNameException.Message;
            }
        }//end updateEstablishmentName

        public string deleteEstaName(int EstablishmentNo)
        {
            try
            {
                string delSql = "DELETE Establishment WHERE EstablishmentNo=@EstaNo";
                SqlCommand delSqlCommand = new SqlCommand(delSql , sql_connection);
                delSqlCommand.Parameters.AddWithValue("@EstaNo", EstablishmentNo);
                sql_connection.Open();
                delSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "deleteEsta";
            }
            catch (Exception deleteEx)
            {
                return deleteEx.Message;
            }
        }//end deleteEstablishmentName
        /////////////////////////////////Establishment Block////////////////////////////////////////////////
        ////////////////////////////////Personal Block////////////////////////////////////////////////////
        public string addPersonalDatas(string FirstName , string LastName , int TitleNo )
        {
            try
            {
                string sqlcmd = "INSERT INTO PERSONAL( FName , SName,TitleNo) VALUES(@Fname ,@Lname,@TNo)";
                SqlCommand Command = new SqlCommand(sqlcmd ,sql_connection);
                Command.Parameters.AddWithValue("@Fname",FirstName);
                Command.Parameters.AddWithValue("@Lname",LastName);
                Command.Parameters.AddWithValue("@TNo",TitleNo);
                sql_connection.Open();
                Command.ExecuteNonQuery();
                sql_connection.Close();
                return "1";
            }
            catch ( Exception Ex)
            {
                return Ex.Message;
                
            }
        }


        public DataSet showPersonalDatas(int PersonalNo)
        {
            try
            {
                string sql_que = ""; 
                    
                   
                 if (PersonalNo==0)
                     sql_que = "  select PersonalNo,T.TitleName ,Fname,Sname, T.TitleNo from Title T, Personal P where T.titleNo = P.titleNo";
                 else
                     sql_que = "  select PersonalNo,TitleName ,Fname,Sname, T.TitleNo from Title T, Personal P where T.titleNo = P.titleNo and PersonalNo ="+PersonalNo.ToString();
                DataSet ds = new DataSet();
                SqlDataAdapter sql = new SqlDataAdapter(sql_que, sql_connection);
                sql_connection.Open();
                sql.Fill(ds);
                sql_connection.Close();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string updatePersonalDatas(string Fname ,string Sname, int TitleNo, int PersonalNo)
        {
            string update_sql = " UPDATE Personal SET Fname=@Fname , Sname=@Sname, TitleNo=@TitleNo WHERE PersonalNo =@PersonalNo ";
            SqlCommand sql = new SqlCommand(update_sql,sql_connection);
            sql.Parameters.AddWithValue("@Fname",Fname);
            sql.Parameters.AddWithValue("@Sname",Sname);
            sql.Parameters.AddWithValue("@TitleNo",TitleNo);
            sql.Parameters.AddWithValue("@PersonalNo",PersonalNo);
            sql_connection.Open();
            sql.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }

        public string deletePersonal(int PersonalNo)
        {
            string sql = "delete Personal where PersonalNo = @PersonalNo";
            SqlCommand sqlCommand = new SqlCommand(sql,sql_connection);
            sqlCommand.Parameters.AddWithValue("@PersonalNo",PersonalNo);
            sql_connection.Open();
            sqlCommand.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }
       
        ////////////////////////////////Personal Block////////////////////////////////////////////////////
        ///////////////////////////////Examination Block/////////////////////////////////////////////////
       
        public DataSet showExaminationDatas(int ExaminationNo)
        {
            try
            {
                string sql_que = "";
                if (ExaminationNo == 0)
                    sql_que = "  select E.ExaminationNo , P.FName as [Patient Fname] , P.Sname as [Patient Sname] , P.TCNo , S.ServiceName  ,E.ExaminationDate , "+
                   " Pe.Fname  as [Personal Fname] , Pe.Sname as [Personal Sname]  , T.TitleName "+
                   " from Examination E ,Patient P , [Service] S , Personal Pe ,Title T "+
                   " where E.PatientNo = P.PatientNo and E.ServiceNo = S.ServiceNo and E.PersonalNo = Pe.PersonalNo and Pe.TitleNo = T.TitleNo ";
                
                else
                    sql_que = "  select *  from Examination Where ExaminationNo =" + ExaminationNo.ToString();
                DataSet ds = new DataSet();
                SqlDataAdapter sql = new SqlDataAdapter(sql_que, sql_connection);
                sql_connection.Open();
                sql.Fill(ds);
                sql_connection.Close();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


       public string addExaminationDatas(int examinationNo, int patientNo, int serviceNo, int personalNo, DateTime examDate)
        {
            try
            {
                string sqlcmd = "";

                if (examinationNo==0)
                    sqlcmd = "INSERT INTO Examination (PatientNo, ServiceNo, PersonalNo , ExaminationDate) VALUES(@pano , @sno, @peno, @exdate)";
                else
                    sqlcmd = "UPDATE Examination set patientNo=@pano, serviceno=@sno, personalNo=@peno, Examinationdate=@exdate where examinationNo=@exNo";


                SqlCommand Command = new SqlCommand(sqlcmd, sql_connection);
                Command.Parameters.AddWithValue("@pano", patientNo);
                Command.Parameters.AddWithValue("@sno", serviceNo);
                Command.Parameters.AddWithValue("@peno", personalNo);
                Command.Parameters.AddWithValue("@exdate", examDate);

                if (examinationNo > 0)
                {
                    Command.Parameters.AddWithValue("@exNo", examinationNo);                        
                }

                sql_connection.Open();
                Command.ExecuteNonQuery();
                sql_connection.Close();
                return "1";
            }
            catch (Exception Ex)
            {
                return Ex.Message;

            }
        }



        public string deleteExamData(int ExaminationNo)
        {
            try
            {
                string delSql = "DELETE Examination WHERE ExaminationNo=@ExNo";
                SqlCommand delSqlCommand = new SqlCommand(delSql, sql_connection);
                delSqlCommand.Parameters.AddWithValue("@ExNo", ExaminationNo);
                sql_connection.Open();
                delSqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                return "1";
            }
            catch (Exception deleteEx)
            {
                return deleteEx.Message;
            }
        }//end deleteEstablishmentName

        ///////////////////////////////Examination Block/////////////////////////////////////////////////
        //////////////////////////////Sending Block/////////////////////////////////////////////////////
        public DataSet showSendingDatas(int SendingNo)
        {
            
            string sendingSqlQuery = "";
            if (SendingNo == 0)
                sendingSqlQuery = "select P.FName, P.Sname, P.TCNo, E.EstablishmentName from Establishment E , Patient P , Examination Ex , Sending S where E.EstablishmentNo = S.EstablishmentNo  and S.ExaminationNo = Ex.ExaminationNo and Ex.PatientNo = P.PatientNo ";
            else
                sendingSqlQuery = "select P.FName, P.Sname, P.TCNo, E.EstablishmentName from Establishment E , Patient P , Examination Ex , Sending S where E.EstablishmentNo = S.EstablishmentNo  and S.ExaminationNo = Ex.ExaminationNo and Ex.PatientNo = P.PatientNo and SendingNo ="+SendingNo.ToString();
            DataSet sendingDataSet = new DataSet();
            SqlDataAdapter sendingSqlDataAdapter = new SqlDataAdapter(sendingSqlQuery , sql_connection);
            sql_connection.Open();
            sendingSqlDataAdapter.Fill(sendingDataSet);
            sql_connection.Close();
            return sendingDataSet;
        }

        public string addSendingDatas(int SendingNo , int ExaminationNo , int EstablishmentNo)
        {
            string sql = "";
            if (SendingNo == 0)
                sql = " insert into Sending (ExaminationNo ,EstablishmentNo) values(@ExaminationNo ,@EstablishmentNo) ";
            else
                sql = "update Sending set (ExaminationNo = @ExaminationNo , EstablishmentNo =@EstablishmentNo) where SendingNo = @SendingNo";
            SqlCommand sqlComm = new SqlCommand(sql , sql_connection);
            sqlComm.Parameters.AddWithValue("@EstablishmentNo",EstablishmentNo);
            sqlComm.Parameters.AddWithValue("@ExaminationNo",ExaminationNo);
            if (SendingNo > 0)
                sqlComm.Parameters.AddWithValue("@SendingNo",SendingNo);
            sql_connection.Open();
            sqlComm.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }

        public string deleteSending(int SendingNo)
        {
            string sql = "delete Sending where SendingNo = @SendingNo";
            SqlCommand sqlc = new SqlCommand(sql ,sql_connection);
            sqlc.Parameters.AddWithValue("@SendingNo",SendingNo);
            sql_connection.Open();
            sqlc.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }
        //////////////////////////////Sending Block/////////////////////////////////////////////////////
        //////////////////////////////ExamDiag/////////////////////////////////////////////////////////
        public DataSet showExamDiagDatas(int ExamDiagNo)
        {
            string examDiagSql = "";
            if (ExamDiagNo == 0)
                examDiagSql = "select P.FName as PatientName , P.Sname as PatientSurname, P.TCNo as TcNo, D.DiagName as Diagnosis from Patient P,  Diagnosis D, Examination Ex, ExamDiag E where Ex.PatientNo = P.PatientNo and Ex.ExaminationNo = E.ExaminationNo and D.DiagNo = E.DiagNo ";
            else
                examDiagSql = "select P.FName as PatientName , P.Sname as PatientSurname, P.TCNo as TcNo, D.DiagName as Diagnosis from Patient P,  Diagnosis D, Examination Ex, ExamDiag E where Ex.PatientNo = P.PatientNo and Ex.ExaminationNo = E.ExaminationNo and D.DiagNo = E.DiagNo and ExamDiagNo ="+ExamDiagNo.ToString();
            DataSet examDiagDataSet = new DataSet();
            SqlDataAdapter examDiagSqlDataAdapter = new SqlDataAdapter(examDiagSql , sql_connection);
            sql_connection.Open();
            examDiagSqlDataAdapter.Fill(examDiagDataSet);
            sql_connection.Close();
            return examDiagDataSet;
        }

        public string addExamDiagDatas(int ExamDiagNo , int ExaminationNo , int DiagNo)
        {
            string sql = "";
            if (ExamDiagNo == 0)
                sql = " insert into ExamDiag ( ExaminationNo , DiagNo) values (  @ExaminationNo , @DiagNo) ";
            else
                sql = " update ExamDiag set (ExaminationNo = @ExaminationNo , DiagNo = @DiagNo) where ExamDiagNo = @ExamDiagNo  ";
            SqlCommand sqlc = new SqlCommand(sql, sql_connection);
            sqlc.Parameters.AddWithValue("@ExaminationNo",ExaminationNo);
            sqlc.Parameters.AddWithValue("@DiagNo",DiagNo);
            if (ExamDiagNo > 0)
                sqlc.Parameters.AddWithValue("@ExamDiagNo",ExamDiagNo);
            sql_connection.Open();
            sqlc.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }

        public string deleteExamDiagDatas(int ExamDiag)
        {
            string sql = "delete ExamDiag where ExamDiag = @ExamDiag";
            SqlCommand comm = new SqlCommand(sql , sql_connection);
            comm.Parameters.AddWithValue("@ExamDiag" , ExamDiag );
            sql_connection.Open();
            comm.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }
        //////////////////////////////ExamDiag/////////////////////////////////////////////////////////
        /////////////////////////////Recipe///////////////////////////////////////////////////////////
        //recipe  RecipeNo (primary key) , Recipe Date , ExaminationNo 
        //recipe de gözükmesi gerekenler: ilaç , reçete tarihi , verildiği hastanın adı, hastanın soyadı, hastanın tcnosu,  veren  personelin ismi, soyismi ve ünvanı
        public DataSet showRecipeDatas(int RecipeNo)
        {
            string recipeSql = "";
            if (RecipeNo == 0)
                recipeSql = "select R.RecipeDate as [Date of Recipe] , D.DrugName as [Name of Drug] , Pers.Fname as [Drug written by Name] , Pers.Sname[Drug written by Surname] , T.TitleName  , P.FName as [Patient Name] , P.Sname as [Patient Surname] , P.TCNo as [TC No] from Recipe R , Examination Ex , Patient P , RecipeDetail RD , Drug D , Personal Pers , Title T where R.ExaminationNo = Ex.ExaminationNo and Ex.PersonalNo = Pers.PersonalNo and Pers.TitleNo = T.TitleNo and Ex.PatientNo = P.PatientNo and R.RecipeNo = RD.RecipeNo and RD.DrugNo = D.DrugNo  ";
            else
                recipeSql = "select R.RecipeDate as [Date of Recipe] , D.DrugName as [Name of Drug] , Pers.Fname as [Drug written by Name] , Pers.Sname[Drug written by Surname] , T.TitleName  , P.FName as [Patient Name] , P.Sname as [Patient Surname] , P.TCNo as [TC No] from Recipe R , Examination Ex , Patient P , RecipeDetail RD , Drug D , Personal Pers , Title T where R.ExaminationNo = Ex.ExaminationNo and Ex.PersonalNo = Pers.PersonalNo and Pers.TitleNo = T.TitleNo and Ex.PatientNo = P.PatientNo and R.RecipeNo = RD.RecipeNo and RD.DrugNo = D.DrugNo and RecipeNo =" + RecipeNo.ToString();
            DataSet recipe = new DataSet();
            SqlDataAdapter recipeDataAdapter = new SqlDataAdapter(recipeSql , sql_connection);
            sql_connection.Open();
            recipeDataAdapter.Fill(recipe);
            sql_connection.Close();
            return recipe;
        }
         

        public DataSet showRecipeDatasByExamNo(int examNo)
        {
            string recipeSql = "";
            recipeSql = " select R.recipeNo, R.recipeDate, P.fName +  ' ' + p.Sname as fullName " +
                " from recipe R, examination E, personal P "  +
                " where R.examinationNo = E.examinationNo  " +
                " and E.personalNo = P.personalNo and E.examinationNo=" + examNo.ToString();
            DataSet recipe = new DataSet();
            SqlDataAdapter recipeDataAdapter = new SqlDataAdapter(recipeSql , sql_connection);
            sql_connection.Open();
            recipeDataAdapter.Fill(recipe);
            sql_connection.Close();
            return recipe;
        }
         


      
        public string addRecipeDatas(int RecipeNo, DateTime RecipeDate, int ExaminationNo)
        {
            string recipeSql = "";
            if (RecipeNo == 0)
                recipeSql = " insert into Recipe ( RecipeDate , ExaminationNo) values ( @RecipeDate , @ExaminationNo ) ";
            else
                recipeSql = " update set (RecipeNo = @RecipeNo , RecipeDate = @RecipeDate , ExaminationNo = @ExaminationNo where ExaminationNo = @ExaminationNo ) ";
            SqlCommand recipeSqlCommand = new SqlCommand(recipeSql , sql_connection);
            recipeSqlCommand.Parameters.AddWithValue("@RecipeDate",RecipeDate);
            recipeSqlCommand.Parameters.AddWithValue("@ExaminationNo",ExaminationNo);
            if(RecipeNo>0)
                recipeSqlCommand.Parameters.AddWithValue("@RecipeNo", RecipeNo);
            sql_connection.Open();
            recipeSqlCommand.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }

        




        public string deleteRecipeDatas(int RecipeNo)
        {
            string recipeSql = " delete Recipe where RecipeNo = @RecipeNo ";
            SqlCommand recipeSqlCommand = new SqlCommand(recipeSql , sql_connection);
            recipeSqlCommand.Parameters.AddWithValue("@RecipeNo",RecipeNo);
            sql_connection.Open();
            recipeSqlCommand.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }
        /////////////////////////////Recipe///////////////////////////////////////////////////////////
        ///////////////////////////////ExamSurvey///////////////////////////////////////////////////////////////
        public DataSet showExamSurvey(int ExamSurveyNo)
        {
            string sql = "";
            if (ExamSurveyNo == 0)
                sql = "select SurveyName , P.FName as [Patient Name] , P.Sname as [Patient Surname] , P.TCNo as [TC No] , Pers.Fname as [Survey Determiner Name] , Pers.Sname as [Survey Determeiner Surname] , T.TitleName from ExamSurvey ES , Examination Ex , Patient P , Personal Pers , Title T ,Survey S where S.SurveyNo = ES.SurveyNo and ES.ExaminationNo = Ex.ExaminationNo and Ex.PatientNo = P.PatientNo  and Ex.PersonalNo = Pers.PersonalNo and Pers.TitleNo = T.TitleNo ";
            else
                sql = "select SurveyName , P.FName as [Patient Name] , P.Sname as [Patient Surname] , P.TCNo as [TC No] , Pers.Fname as [Survey Determiner Name] , Pers.Sname as [Survey Determeiner Surname] , T.TitleName from ExamSurvey ES , Examination Ex , Patient P , Personal Pers , Title T ,Survey S where S.SurveyNo = ES.SurveyNo and ES.ExaminationNo = Ex.ExaminationNo and Ex.PatientNo = P.PatientNo  and Ex.PersonalNo = Pers.PersonalNo and Pers.TitleNo = T.TitleNo and ExamSurveyNo =" + ExamSurveyNo.ToString();
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql , sql_connection);
            sql_connection.Open();
            sqlDataAdapter.Fill(ds);
            sql_connection.Close();
            return ds;
        }

        public string addExamSurveyDatas(int ExamSurveyNo, int ExaminationNo, int SurveyNo)
        {
            string sql = "";
            if (ExamSurveyNo == 0)
                sql = " insert into ExamSurvey ( ExaminationNo , SurveyNo ) values (@ExaminationNo , @SurveyNo) ";
            else
                sql = " update ExamSurvey set (ExaminationNo = @ExaminationNo , SurveyNo = @SurveyNo ) where ExamSurveyNo = @ExamSurveyNo ";
            SqlCommand comm = new SqlCommand(sql , sql_connection);
            comm.Parameters.AddWithValue("@ExaminationNo",ExaminationNo);
            comm.Parameters.AddWithValue("@SurveyNo",SurveyNo);
            if (ExamSurveyNo > 0)
                comm.Parameters.AddWithValue("@ExamSurveyNo",ExamSurveyNo);
            sql_connection.Open();
            comm.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }

        public string deleteExamSurveyDatas(int ExamSurveyNo)
        {
            string sql = "delete ExamSurvey where ExamSurveyNo = @ExamSurveyNo";
            SqlCommand comm = new SqlCommand(sql , sql_connection);
            comm.Parameters.AddWithValue("@ExamSurveyNo",ExamSurveyNo);
            sql_connection.Open();
            comm.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }
        ///////////////////////////////ExamSurvey///////////////////////////////////////////////////////////////
        ////////////////////////////////RecipeDetail////////////////////////////////////////////////////////////
        public DataSet showRecipeDetail(int RecipeDetailNo)

        {
            string sql = "";
            if (RecipeDetailNo == 0)
                sql = "select D.DrugName , R.RecipeDate from RecipeDetail RD , Recipe R , Drug D where RD.RecipeNo = R.RecipeNo AND RD.DrugNo = D.DrugNo";
            else
                sql = "select D.DrugName , R.RecipeDate from RecipeDetail RD , Recipe R , Drug D where RD.RecipeNo = R.RecipeNo AND RD.DrugNo = D.DrugNo and RecipeDetailNo =" + RecipeDetailNo.ToString();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sql , sql_connection);
            sql_connection.Open();
            sda.Fill(ds);
            sql_connection.Close();
            return ds;
        }

        public string addRecipeDetailForm(int RecipeDetailNo, int RecipeNo, int DrugNo)
        {
            string sql = "";
            if (RecipeDetailNo == 0)
                sql = " insert into RecipeDetail (RecipeNo , DrugNo) values (@RecipeNo , @DrugNo) ";
            else
                sql = "update RecipeDetail set (RecipeNo = @RecipeNo , DrugNo = @DrugNo) where RecipeDetailNo = @RecipeDetailNo";
            SqlCommand sc = new SqlCommand(sql , sql_connection);
            sc.Parameters.AddWithValue("@RecipeNo" , RecipeNo);
            sc.Parameters.AddWithValue("@DrugNo" , DrugNo);
            if (RecipeDetailNo > 0)
                sc.Parameters.AddWithValue("@RecipeDetailNo",RecipeDetailNo);
            sql_connection.Open();
            sc.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }

        public string deleteRecipeDetailForm(int RecipeDetailNo)
        {
            string sql = "delete RecipeDetail where RecipeDetailNo = @RecipeDetailNo";
            SqlCommand sc = new SqlCommand();
            sc.Parameters.AddWithValue("@RecipeDetailNo",RecipeDetailNo);
            sql_connection.Open();
            sc.ExecuteNonQuery();
            sql_connection.Close();
            return "1";
        }
        ////////////////////////////////RecipeDetail////////////////////////////////////////////////////////////
    }//end classHib
}//end namespace hbys_winApp
