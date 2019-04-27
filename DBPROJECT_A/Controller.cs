using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBPROJECT_A
{
    class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        public int CalculateRateOfGarage(int GID)
        {
            try
            {
                string query = "select AVG(RatingValue) from Rate where G_ID = " + GID;
                int AVG = Convert.ToInt32(dbMan.ExecuteScalar(query));
                query = "select SUM(RatingValue) from Rate where G_ID = " + GID;
                int sum = Convert.ToInt32(dbMan.ExecuteScalar(query));
                int value = (5 * AVG) / sum;
                query = "update Garage set RatingValue = " + value + "where G_ID = " + GID;
                return dbMan.ExecuteNonQuery(query);
        }
            catch(System.InvalidCastException)
            {
                return 0;
            }
}

        public int insertGarage(string GarageName, int numberOfSlots, string Address, int costPerHour, int workerNum, string City, int ownerid)
        {
            string query = "select max(G_ID) from Garage";
            object Obj = dbMan.ExecuteScalar(query);
            int garageid;
            if (Obj == DBNull.Value)
                garageid = 1;
            else
                garageid = Convert.ToInt32(Obj) + 1;
            query = "insert into Garage(G_ID,Address,NumOfSlots,SoltCostPerHour,OwnerId,NumOfFreeSlots,WorkersNum,Garage_Name,City) values(" + garageid + ",'" + Address + "'," + numberOfSlots + "," + costPerHour + "," + ownerid + "," + numberOfSlots + "," + workerNum + ",'" + GarageName + "','" + City + "')";
            int n = dbMan.ExecuteNonQuery(query);
            if (n == 0)
                return 1;
            for (int i = 1; i <= numberOfSlots; i++)
                insertSlot(i, garageid);
            return 2;
        }

        public int GetNumOfFreeSlots(int GID)
        {
            string query = "select NumOfFreeSlots from Garage where G_ID = " + GID;
            return (int)dbMan.ExecuteScalar(query);
        }

        public int DeleteCustomerattachments(string username)
        {
            string query = "select CarID from Car where CustomerUserName = '" + username + "'";
            object Obj = dbMan.ExecuteScalar(query);
            query = "delete from PromoCode where CustomerUserName = '" + username + "'";
            dbMan.ExecuteNonQuery(query);
            if (Obj != null)
            {
                string carid = (string)Obj;
                query = "delete from OrderOfWash where Car_ID = '" + carid + "'";
                dbMan.ExecuteNonQuery(query);
                query = "delete from OrderOfWorkShop where Car_ID = '" + carid + "'";
                dbMan.ExecuteNonQuery(query);
                
                return 1;
            }
            return 0;

        }

        public object checkPassword_Owner(string username,string password)
        {
            string query = "SELECT OwnerId from OwnerOfGarage where Email = '" + username +"' and password = '"+ password +"'";
            return dbMan.ExecuteScalar(query);
        }

        public DataTable checkPassword_Customer(string username, string password)
        {
            string query = "SELECT UserName from Customer where Email = '" + username + "' and PassWord = '" + password + "'";
            return dbMan.ExecuteReader(query);
        }

        public object checkPassword_Worker(string username, string password)
        {
            string query = "SELECT W_ID from Worker where Email = '" + username + "' and Password = '" + password + "'";
            return dbMan.ExecuteScalar(query);
            
        }

        public int insertCustomer(string username, string password, string Email, string Address, string date)
        {
            string query = "insert into Customer(UserName,Email,PassWord,BirthDate,Address) values('" + username + "','" + Email + "','" + password + "',convert(varchar,'" + date + "',101),'" + Address + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int insertOwner(string username, string password, string Email, string Address, int numberOfSlots, int costPerHour, int workerNum, string GarageName, string City)
        {
            string query = "select max(OwnerId) from OwnerOfGarage";
            object Obj = dbMan.ExecuteScalar(query);
            int ownerid;
            if (Obj == DBNull.Value)
            {
                ownerid = 1;
                query = "insert into OwnerOfGarage(OwnerId,Email,password) values(" + ownerid + ",'" + Email + "','" + password + "')";
                int k = dbMan.ExecuteNonQuery(query);
                if (k == 0)
                    return k;
            }
            else
            {
                ownerid = Convert.ToInt32(Obj) + 1;
                query = "insert into OwnerOfGarage(OwnerId,Email,password) values(" + ownerid + ",'" + Email + "','" + password + "')";
                int k = dbMan.ExecuteNonQuery(query);
                if (k == 0)
                    return k;
            }
            query = "select max(G_ID) from Garage";
            Obj = dbMan.ExecuteScalar(query);
            int garageid;
            if (Obj == DBNull.Value)
            {
                garageid = 1;
                query = "insert into Garage(G_ID,Address,NumOfSlots,SoltCostPerHour,OwnerId,NumOfFreeSlots,WorkersNum,Garage_Name, City) values(" + garageid + ",'" + Address + "'," + numberOfSlots + "," + costPerHour + "," + ownerid + "," + numberOfSlots + "," + workerNum + ",'" + GarageName + "', '" + City + "')";
                int n = dbMan.ExecuteNonQuery(query);
                if (n == 0)
                    return 1;
            }
            else
            {
                garageid = Convert.ToInt32(Obj) + 1;
                query = "insert into Garage(G_ID,Address,NumOfSlots,SoltCostPerHour,OwnerId,NumOfFreeSlots,WorkersNum,Garage_Name,City) values(" + garageid + ",'" + Address + "'," + numberOfSlots + "," + costPerHour + "," + ownerid + "," + numberOfSlots + "," + workerNum + ",'" + GarageName +"','" + City +"')";
                int n = dbMan.ExecuteNonQuery(query);
                if (n == 0)
                    return 1;
            }
            for (int i = 1; i <= numberOfSlots; i++)
            {
                insertSlot(i, garageid);
            }
            return 2;
        }

        public object checkonDurationCustomer(string username)
        {
            string query = "select Duration from Customer where UserName = '" + username + "'";
            return dbMan.ExecuteScalar(query);
        }

        public object checkonCostCustomer(string username)
        {
            string query = "select Cost from Customer where UserName = '" + username + "'";
            return dbMan.ExecuteScalar(query);
        }

        public int setDurationCostCustomernull(string username)
        {
            string query = "update Customer set Duration = NULL, Cost = NULL where UserName = '" + username + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getOwnerId()
        {
            string query = "select OwnerId from OwnerOfGarage";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getCustomerUsername()
        {
            string query = "select UserName from Customer";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getOwnerGarageId(int OwnerId)
        {
            string query = "select G_ID from Garage where OwnerId = " + OwnerId + "";
            return dbMan.ExecuteReader(query);
        }

        public int getOwnerGarageCount(int OwnerId)
        {
            string query = "select count(*) from Garage where OwnerId = " + OwnerId + "";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int DeleteWorker(int gID)
        {
            string query = "delete from Worker where G_ID = " + gID + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteGarage(int gID)
        {
            string query = "delete from Garage where G_ID = " + gID;
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteOwner(int oID)
        {
            string query = "delete from OwnerOfGarage where OwnerId = " + oID + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteCustomer(string username)
        {
            string query = "delete from Customer where UserName = '" + username + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int countCustomerCars(string username)
        {
            string query = "select count(*) from Car where CustomerUserName = '" + username + "'";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public object getcarIDbyusername(string username)
        {
            string query = "select CarID from OrderOfWash where CustomerUserName = '" + username;
            return dbMan.ExecuteScalar(query);
        }

        public int DeleteCars(string username)
        {
            string query = "delete from Car where CustomerUserName = '" + username + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getAdminID()
        {
            string query = "select AdminID from Admin where AdminID <> 1";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteAdmin(int AdminID)
        {
            string query = "delete from Admin where AdminID = " + AdminID + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertAdmin(string Email, string Password)
        {
            string query = "select max(AdminID) from Admin";
            int max = Convert.ToInt32(dbMan.ExecuteScalar(query));
            query = "insert into Admin(AdminID,Email,password) values(" + (max+1) + ",'" + Email + "','" + Password + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int insertSlot(int slotId, int garageId)
        {
            string query = "insert into Slots(Slot_ID,G_ID) values(" + slotId + "," + garageId + ")";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteSlot(int GID)
        {
            string query = "delete from Slots where G_ID = "+ GID;
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteGarageRate(int GID)
        {
            string query = "delete from Rate where G_ID = " + GID;
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getUsernamesofGarage(int GID)
        {
            string query = "select UserName from Customer where G_ID = " + GID;
            return dbMan.ExecuteReader(query);
        }

        public object getCountofParkedCustomers(int GID)
        {
            string query = "select count(*) from Customer where  G_ID = " + GID;
            return dbMan.ExecuteScalar(query);
        }

        public int deleteGidSlotIdByUsername(string username)
        {
            string query = "update customer set G_ID = NULL , Slot_ID = NULL where UserName = '" + username + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public object checkPasswordAdmin(string Email, string password)
        {
            string query = "select AdminID from Admin where Email = '" + Email + "' and password = '" + password + "'";
            return dbMan.ExecuteScalar(query);
        }

        public int UpdateOrdersOfWorkshop(int Orderid, int GID, String Before, string After,int Done, int cost)
        {
            string query;
            //int q1 = 0;
            if (Done == 1)
            {
                query = "Update OrderOfWorkShop set DesBefore = '" + Before + "', DesAfter = '" + After + "', FixedOrNot = " + Done +", Cost = " + cost + " where G_ID = " + GID + " and Order_ID =  " + Orderid;
                return dbMan.ExecuteNonQuery(query);
                //query = "delete from OrderOfWorkShop where Order_ID ="+ Orderid + " and G_ID = "+ GID;
                //return (dbMan.ExecuteNonQuery(query) != 0 && q1 != 0 )? 1:0;
            }
            else
            {
                query = "Update OrderOfWorkShop set DesBefore = '" + Before +"', FixedOrNot = " + Done+", Cost = " + cost + " where G_ID = " + GID + " and Order_ID =  " + Orderid;
                return dbMan.ExecuteNonQuery(query);
            }
            
        }
        public int UpdateOrdersOfWash(int orderID,int Gid,int Done, int cost)
        {
            int q1 = 0;
            if (Done == 1)
            {
                string query = "Update OrderOfWash set DoneOrNot = " + Done + ", Cost = " + cost + " where G_ID = " + Gid + " and Order_ID =" + orderID;
                q1 = dbMan.ExecuteNonQuery(query);

                decimal profit = getGarage_Profit(Gid);
                profit += (decimal)cost;
                update_profit(Gid, profit);
            }
            

            return q1;
        }

        

        public int MoveOrder(string user_name)
        {
            string query = "select Order_ID, o.G_ID,o.Car_ID  from OrderOfWorkShop o, Car, Customer where Car_ID = Car_ID And UserName = CustomerUserName and CustomerUserName = '" + user_name + "'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt == null)
            {
                return 0;
            }
            int OID = (int)dt.Rows[0]["Order_ID"];
            int Gid = (int)dt.Rows[0]["G_ID"];
            string cid = (string)dt.Rows[0]["Car_ID"];
            object orderID;
            //string query = "Select max(Order_ID) From OrderOfWorkShop where G_ID = " + Gid;
            //object orderID = dbMan.ExecuteScalar(query);
            //int OID;
            //if (orderID == DBNull.Value)
            //{
            //    OID = 1;
            //}
            //else
            //{
            //    OID = (int)orderID + 1;
            //}
            query = "select Cost,DesBefore,DesAfter From OrderOfWorkShop where Order_ID = " + OID + "and G_ID = " + Gid;
            dt = dbMan.ExecuteReader(query);
            if (dt.Rows[0][0] == DBNull.Value || dt.Rows[0][1] == DBNull.Value || dt.Rows[0][2] == DBNull.Value)
            {
                query = "delete from OrderOfWorkShop where Order_ID =" + OID + " and G_ID = " + Gid;
                return dbMan.ExecuteNonQuery(query);
            }
            decimal cost = (decimal)dt.Rows[0]["Cost"];
            string Before = (string)dt.Rows[0]["DesBefore"];
            string After = (string)dt.Rows[0]["DesAfter"];

            

            query = "delete from OrderOfWorkShop where Order_ID =" + OID + " and G_ID = " + Gid;
            int q1 = dbMan.ExecuteNonQuery(query);

            query = "Select max(Order_ID) From Archive";
            orderID = dbMan.ExecuteScalar(query);
            if (orderID == DBNull.Value)
            {
                OID = 1;
            }
            else
            {
                OID = (int)orderID + 1;
            }
            query = "Insert into Archive (Archive_ID,Cost,DesBefore,DesAfter,carid) values(" + OID + "," + cost + ",'" + Before + "','" + After + "','"+ cid + "')";
            int q2 = dbMan.ExecuteNonQuery(query);

            decimal profit = getGarage_Profit(Gid);
            profit += cost;
            update_profit(Gid, profit);


            return (q1 & q2);
        }

        public int DeleteFromWash(string user_name)
        {
            string query = "select Order_ID, o.G_ID from OrderOfWash o, Car, Customer where Car_ID = Car_ID And UserName = CustomerUserName and CustomerUserName = '" + user_name + "'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt == null)
            {
                return 0;
            }
            int OID = (int)dt.Rows[0]["Order_ID"];
            int Gid = (int)dt.Rows[0]["G_ID"];
            query = "delete from OrderOfWash where Order_ID =" + OID + " and G_ID = " + Gid;
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteFromWorkShop(string user_name)
        {
            string query = "select Order_ID, o.G_ID from OrderOfWash o, Car, Customer where Car_ID = Car_ID And UserName = CustomerUserName and CustomerUserName = '" + user_name + "'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt == null)
            {
                return 0;
            }
            int OID = (int)dt.Rows[0]["Order_ID"];
            int Gid = (int)dt.Rows[0]["G_ID"];
            query = "delete from OrderOfWash where Order_ID =" + OID + " and G_ID = " + Gid;
            return dbMan.ExecuteNonQuery(query);
        }

        /************************************************ahmed *********************************************/
        /*
        * this function will update the address of the worker 
        */
        public int UpdateAddress(string address, int id)
        {
            string query = "update Worker set Address = '" + address + "'	where W_ID=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        /*
         *here i  will update the password of the emoloyee but  i assme that the worker is is unique for all the garages in the app 
         */
        public int UpdatePassword(string pass, int id)
        {
            string query = "update Worker set Password = '" + pass + "'	where W_ID=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        /*
         * get the information f a sepcific worker by his id  
         */
        public DataTable SelectWorker(int id)
        {
            string query = "SELECT * FROM Worker where W_ID=" + id;
            return dbMan.ExecuteReader(query);
        }
        // show the requests 
        public DataTable Select_The_Request(int g_id)
        {
            string query = " select Slot_ID from Slots where State = 0 And Request = 1 AND G_ID = " + g_id + ";";
            return dbMan.ExecuteReader(query);
        }

        // show the reserved slots 
        public DataTable Select_The_reserved(int g_id)
        {
            string query = " select Slot_ID from Slots where State = 1 And Request = 1 AND G_ID = " + g_id + ";";
            return dbMan.ExecuteReader(query);
        }

        // Accept the request and set the start time of the reserving 
        public int Accept_Request(int g_id, int s_id)
        {
            string query = "update Slots  set State = 1 where Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetSlotIdGidtoCustomer(int g_id, int s_id,string CustomerUsername)
        {
            string query = "update Slots  set State = 1 where Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        // set the start time  
        public int Set_StartTime(int g_id, int s_id)
        {
            string query = "update Slots  set StartUse = (getdate()) where  Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        // set the State to be 0 -> not reserved  
        public int Free(int g_id, int s_id)
        {
            string query = "update Slots  set State = 0, Request = 0 where Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        // set the END time  
        public int Set_ENDTime(int g_id, int s_id)
        {
            string query = "update Slots  set EndUse = (getdate()) where  Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        // Get the GarageID For the Worker   
        public int Get_GarageID(int id)
        {
            string query = "select G_ID from Worker where W_ID= " + id + ";";
            return (int)dbMan.ExecuteScalar(query);
        }

        // Get the GarageSoltCostPerHour For the Worker   
        public decimal Get_SoltCostPerHour(int g_id)
        {
            string query = "select SoltCostPerHour from Garage where G_ID=" + g_id + ";";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        //get a spesific slot from the Slots by its id AND G_ID
        public DataTable Get_Slot(int g_id, int s_id)
        {
            string query = "select * from Slots where Slot_ID=" + s_id + " AND G_ID=" + g_id + ";";
            return dbMan.ExecuteReader(query);
        }


        // update Alltime in the custmer 
        // note i make the Alltimehewasin default 0
        public int update_all_times(int g_id, int s_id)
        {
            string query = "update Customer  set AllTimesHeWasIn = AllTimesHeWasIn + 1 where Slot_ID =" + s_id + "  AND G_ID =" + g_id + " ;";
            return dbMan.ExecuteNonQuery(query);
        }

        // remove the slotid from the user when he leaves the garage in the custmer 
        // note i make the Alltimehewasin default 0
        public int remove_SlotID_from_Customer(int g_id, int s_id)
        {
            string query = "update Customer  set Slot_ID = NULL where Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        // update the cost for the customer in aspesific slot and spesific garage
        // note i make the Alltimehewasin default 0
        public int update_COST_Customer(int g_id, int s_id, decimal cost)
        {
            string query1 = "select Active_PromoCode from Customer where  Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            Object Obj = dbMan.ExecuteScalar(query1);
            if (Obj != null) 
            {
                 cost = cost - Convert.ToDecimal(0.2) * cost;
            }
            string query = "update Customer  set Cost = " + cost + " where  Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        // update the Duration for the customer in aspesific slot and spesific garage
        // note i make the Alltimehewasin default 0
        public int update_Duration_Customer(int g_id, int s_id, decimal Du)
        {
            string query = "update Customer  set Duration= " + Du + " where  Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        // update the nuber of free slots in a spesific garage
        // note i make the Alltimehewasin default 0
        public int dec_number_slots(int g_id)
        {
            string query = "update Garage  set NumOfFreeSlots=NumOfFreeSlots-1 where   G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        // update the nuber of free slots in a spesific garage
        // note i make the Alltimehewasin default 0
        public int inc_number_slots(int g_id)
        {
            string query = "update Garage  set NumOfFreeSlots=NumOfFreeSlots+1 where   G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        // Get the username for a spesific slot and garage
        // note i make the Alltimehewasin default 0
        public DataTable Get_UserName(int g_id, int s_id)
        {
            string query = "select * from Customer where Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteReader(query);
        }

        // Get the name of the dependent and his/her gender and ability
        // note i make the Alltimehewasin default 0
        public DataTable Get_Dependents(string name)
        {
            string query = "select Name from Dependent where CustomerUserName='" + name + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetOrdersOfWS(int GID)
        {
            string query = "Select Order_ID,Car_ID, UserName, Cu.Slot_ID From Customer Cu, OrderOfWorkShop W , Car Ca, Slots S where W.Car_ID = Ca.CarID AND Ca.CustomerUserName = Cu.UserName AND Cu.Slot_ID = S.Slot_ID AND Cu.G_ID = S.G_ID AND S.State = 1 AND W.G_ID = " + GID;
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetOrdersOfWash(int GID)
        {
            string query = "Select Order_ID,Car_ID, UserName, Cu.Slot_ID From Customer Cu, OrderOfWash W , Car Ca, Slots S where W.Car_ID = Ca.CarID AND Ca.CustomerUserName = Cu.UserName AND Cu.Slot_ID = S.Slot_ID AND Cu.G_ID = S.G_ID AND S.State = 1 AND W.G_ID = " + GID;
            return dbMan.ExecuteReader(query);
        }
        public int getGarageIDofWorker(int id)
        {
            string query = "Select G_ID From Worker where G_ID = " + id;
            return (int)dbMan.ExecuteReader(query).Rows[0]["G_ID"];
        }


        // Get the GarageSoltCostPerHour For the Worker   
        public object Get_Max_prormo()
        {
            string query = "select max(Promocode) from  PromoCode;";
            return dbMan.ExecuteScalar(query);
        }

        // Get the GarageSoltCostPerHour For the Worker   
        public object Get_Max_numberOftimes_INGarage()
        {
            string query = "select max(AllTimesHeWasIn) from Customer ;";
            return dbMan.ExecuteScalar(query);
        }


        public DataTable userNames_TOGetPromoCode(int times)
        {
            string query = "select UserName from Customer  where AllTimesHeWasIn=" + times + ";";
            return dbMan.ExecuteReader(query);
        }

        public int insert_into_promocode(string name, int promo)
        {
            string query = "insert into PromoCode(Promocode,CustomerUserName) values  ("+promo+",'" + name + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        // Get the GarageSoltCostPerHour For the Worker   
        public int getnumofcustomer(int n)
        {
            string query = "select count(*) from Customer where AllTimesHeWasIn=" + n + ";";
            return (int)dbMan.ExecuteScalar(query);
        }

        // delete the car 
        // after delete the fk from the order of the wash and  repair
        public int delete_Car(string username)
        {
            string query = "DELETE FROM Car WHERE CustomerUserName='" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        // get the customer username
        public string get_Username2(int g_id, int s_id)
        {
            string query = "Select UserName From Customer where Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return (string)dbMan.ExecuteReader(query).Rows[0]["UserName"];
        }

        //  get the garage name 
        // get the customer username
        public string get_garageName(int g_id)
        {
            string query = "select Garage_Name from Garage where G_ID=" + g_id + ";";
            return (string)dbMan.ExecuteReader(query).Rows[0]["Garage_Name"];
        }


        public DataTable get_activepromo_from_user(int g_id, int s_id)
        {
            string query = "select Active_PromoCode from Customer where Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteReader(query);
        }


        public int delete_promo(string username,int promo)
        {
            string query = "DELETE FROM PromoCode WHERE Promocode="+promo+"AND CustomerUserName='"+ username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int set_activepromocode(int g_id, int s_id)
        {
            string query = "update Customer set Active_PromoCode=0 where Slot_ID =" + s_id + "  AND G_ID =" + g_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable Get_Archive(int C_id)
        {
            string query = "select * from Archive where carid = "+C_id+";";
            return dbMan.ExecuteReader(query);
        }


        public DataTable Get_Car_id_Archive()
        {
            string query = "select DISTINCT carid from Archive ;";
            return dbMan.ExecuteReader(query);
        }

        public decimal getGarage_Profit(int g_id)
        {
            string query = "SELECT TotalProfit FROM Garage WHERE G_ID="+g_id+";";
            return (decimal)dbMan.ExecuteReader(query).Rows[0]["TotalProfit"];
        }

        public int update_profit(int g_id,decimal p)
        {
            string query = "UPDATE dbo.Garage SET TotalProfit = "+p+"WHERE G_ID="+g_id+"; ";
            return dbMan.ExecuteNonQuery(query);
        }

        /****************end ahmed ********************/
        /****************end ahmed ********************/

        /******************salma ******************************/
        public object getslotid(string username)
        {
            string query = "select Slot_ID From Customer where(UserName = '" + username + "')";
            return dbMan.ExecuteScalar(query);
        }
        public DataTable GetCustomerBySSN(String UserName)
        {
            String query = "Select * From Customer where UserName = " +
                "'" + UserName + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectFreeGarages()
        {
            string query = "Select DISTINCT City,  g.G_ID From Garage g, slots s where g.G_ID = s.G_ID and Request = 0";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectFreeSlots(int G_ID)
        {
            string query = "Select Slot_ID, State, SoltCostPerHour From Garage g,Slots s where g.G_ID = s.G_ID " +
                "AND g.G_ID =  " + G_ID.ToString() +
                "AND State = 0";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectFreeGaragesInCity(int G_ID)
        {
            string query = "Select  G_ID, Address, NumOfFreeSlots, RatingValue From Garage where NumOfFreeSlots NOT IN(0) AND City IN (Select City From Garage Where G_ID = " + G_ID + ")";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectGaragInfo(int G_ID)
        {
            string query = "Select * From Garage where G_ID = " + G_ID;
            return dbMan.ExecuteReader(query);
        }
        public int InsertCar(string CARID, string Type, string Color, int needwash, int needrepair, String CustomerName)
        {
            string query = "Insert Into Car (CarID, Type, Color, needWash, needRepair, CustomerUserName) Values( " +
                "'" + CARID + "'," +
                "'" + Type + "'," +
                "'" + Color + "'," +
                needwash + ","
                + needrepair + "," +
                "'" + CustomerName + "'" +
                ")";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateCustomer(string Email, string Password, string Address, String Name)
        {
            string query = "Update Customer set Email = '" + Email + "', Password = '" + Password + "', Address = '" + Address + "' where UserName = '" + Name + "'";
            return dbMan.ExecuteNonQuery(query);
        }
        public object GetRequestedSlot(int GID)
        {
            string query = "select min(Slot_ID) From Slots where Request = 0 AND G_ID = " + GID;
            return dbMan.ExecuteScalar(query);
        }

        public int GetCustomerSlot(int slotid, int GID, string name,int promocode )
        {
            string query1 = "update Customer set Slot_ID = " + slotid + ", G_ID = " + GID + ", Active_PromoCode = " + promocode + " where UserName = '" + name + "'";
            int Q1 = dbMan.ExecuteNonQuery(query1);

            string query2 = "update Slots set Request = 1 where Slot_ID = " + slotid + " and G_ID = " + GID;
            int Q2 = dbMan.ExecuteNonQuery(query2);

            return (Q1 & Q2);
        }
        public int Requestslot(int GID, int SLOTID)
        {
            string query = "update Slots set Request = 1  where Slot_ID = " + SLOTID + " and G_ID = " + GID;
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable GetPromoCode(String CustomerName)
        {
            string query = "select Promocode from PromoCode where CustomerUserName = '" + CustomerName + "'";
            return dbMan.ExecuteReader(query);
        }
        public int OrderRepair(int GID, string CarId)
        {
            string query = "select max(Order_ID) from OrderOfWorkshop where G_ID = " + GID;
            object Obj = dbMan.ExecuteScalar(query);
            int id;
            if (Obj == DBNull.Value)
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt32(Obj) + 1;
            }
            query = "Insert into OrderOfWorkshop(G_ID, Order_ID, Car_ID) Values(" + GID + ", " + id + " , '" + CarId + "')";
            int k = dbMan.ExecuteNonQuery(query);
            return 1;
        }
        public int Orderwash(int GID, string CarId)
        {
            string query = "select max(Order_ID) from OrderOfWash where G_ID = " + GID;
            object Obj = dbMan.ExecuteScalar(query);
            int id;
            if (Obj == DBNull.Value)
            {
                id = 1;
                query = "Insert into OrderOfWash(G_ID, Order_ID, Car_ID) Values(" + GID + ", " + id + " , '" + CarId + "') ";
                int k = dbMan.ExecuteNonQuery(query);
                if (k == 0)
                    return k;
            }
            else
            {
                id = Convert.ToInt32(Obj) + 1;
                query = "Insert into OrderOfWash(G_ID, Order_ID, Car_ID) Values(" + GID + ", " + id + " , '" + CarId + "') ";
                int k = dbMan.ExecuteNonQuery(query);
                if (k == 0)
                    return k;
            }
            return 1;
        }
        public DataTable getallDependent(String CustomerName)
        {
            string query = "Select Name From Dependent Where CustomerUserName = '" + CustomerName + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetGarageofCustomer(String Customer)
        {
            string query = "Select G_ID From Customer where UserName = '" + Customer + "'";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateRate(int RateValue, string Customer)
        {
            int gid = (int)GetGarageofCustomer(Customer).Rows[0]["G_ID"];
            string query = "Update Rate set RatingValue = " + RateValue + " where CustomerUserName = '" + Customer + "' and G_ID = " + gid;
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertRate(int RateValue, string Customer)
        {
            int G_ID = (int)GetGarageofCustomer(Customer).Rows[0]["G_ID"];
            string query = "Insert Into Rate (G_ID, CustomerUserName, RatingValue) Values (" + G_ID + ",'" + Customer + "', " + RateValue + ")";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable checkRateExist(string Customer)
        {
            int G_ID = (int)GetGarageofCustomer(Customer).Rows[0]["G_ID"];
            string query = "Select * from Rate where G_ID = " + G_ID + " and CustomerUserName = '" + Customer + "'";
            return dbMan.ExecuteReader(query);
        }
        public int AddDep(string CustomerName, string Name)
        {
            string query = "Insert into Dependent (CustomerUserName, Name) Values('" + CustomerName + "', '" + Name + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteDep(string customer, string Name)
        {
            string query = "Delete From Dependent where CustomerUserName = '" + customer + "' AND Name = '" + Name + "'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int remove_garageid(string user)
        {
            string query = "Update Customer set G_ID = NULL where UserName = '" + user + "'";
            return dbMan.ExecuteNonQuery(query);
        }


        /********************************end salma ************************************/

        public DataTable Get_garageid_from_ownerid (int oid)
        {
            string query = "SELECT dbo.Garage.G_ID,Garage_Name FROM  dbo.Garage WHERE OwnerId=" + oid+";";
            return dbMan.ExecuteReader(query);
        }

        public int insert_worker(string name,decimal salary,TimeSpan time, string pass,string add,string e,int gid)
        {
            string query = "select max(W_ID ) from Worker";
            object Obj = dbMan.ExecuteScalar(query);
            int id;
            if (Obj == DBNull.Value)
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt32(Obj) + 1;
            }
            string query1 = " INSERT INTO dbo.Worker ( W_ID, Name,Salary,TimeShift,Password, Address,G_ID,Email) VALUES ("+id+",'"+name+"',"+salary+",'"+time+"','"+pass+"','"+add+"',"+gid+",'"+e+"');";
            return dbMan.ExecuteNonQuery(query1);
        }

        public DataTable show_worker(int oid)
        {
            string query = " SELECT Name,G_ID,Email,W_ID FROM dbo.Worker WHERE G_ID IN(SELECT G_ID FROM dbo.Garage WHERE OwnerId=" + oid+" );";
            return dbMan.ExecuteReader(query);
        }

        public int Delete_spesific_Worker(int wid)
        {
            string query = "delete from Worker where W_ID = "+wid+";";
            return dbMan.ExecuteNonQuery(query);
        }


    }
}

