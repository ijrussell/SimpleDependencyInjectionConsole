using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace SimpleDependencyInjectionConsole
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connection;

        public CustomerRepository(string connection)
        {
            _connection = connection;
        }

        public Customer GetCustomer(string id)
        {
            //using (var cn = new SqlConnection(_connection))
            //{
            //    cn.Open();

            //    return cn.Query<Customer>("SELECT * FROM Customers WHERE CustomerId = CustomerId", new {CustomerId = id}).FirstOrDefault();
            //}

            return Customers().FirstOrDefault(x => x.CustomerId == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            //using (var cn = new SqlConnection(_connection))
            //{
            //    cn.Open();

            //    return cn.Query<Customer>("SELECT * FROM Customers");
            //}

            return Customers();
        }

        private static IEnumerable<Customer> Customers()
        {
            return new List<Customer>
                {
                    new Customer {CustomerId = "ALFKI", CompanyName = "IJR Services", Country = "Germany"},
                    new Customer
                        {
                            CustomerId = "ANATR",
                            CompanyName = "Ana Trujillo Emparedados y helados",
                            Country = "Mexico"
                        },
                    new Customer {CustomerId = "ANTON", CompanyName = "Antonio Moreno Taquería", Country = "Mexico"},
                    new Customer {CustomerId = "AROUT", CompanyName = "Around the Horn", Country = "UK"},
                    new Customer {CustomerId = "BERGS", CompanyName = "NxtGenUG", Country = "Sweden"},
                    new Customer {CustomerId = "BLAUS", CompanyName = "Blauer See Delikatessen", Country = "Germany"},
                    new Customer {CustomerId = "BLONP", CompanyName = "Blondesddsl père et fils", Country = "France"},
                    new Customer {CustomerId = "BOLID", CompanyName = "Bólido Comidas preparadas", Country = "Spain"},
                    new Customer {CustomerId = "BONAP", CompanyName = "Bon app'", Country = "France"},
                    new Customer {CustomerId = "BOTTM", CompanyName = "Bottom-Dollar Markets", Country = "Canada"},
                    new Customer {CustomerId = "BSBEV", CompanyName = "B's Beverages", Country = "UK"},
                    new Customer
                        {
                            CustomerId = "CACTU",
                            CompanyName = "Cactus Comidas para llevar",
                            Country = "Argentina"
                        },
                    new Customer {CustomerId = "CENTC", CompanyName = "Centro comercial Moctezuma", Country = "Mexico"},
                    new Customer {CustomerId = "CHOPS", CompanyName = "Chop-suey Chinese", Country = "Switzerland"},
                    new Customer {CustomerId = "COMMI", CompanyName = "Comércio Mineiro", Country = "Brazil"},
                    new Customer {CustomerId = "CONSH", CompanyName = "Consolidated Holdings", Country = "UK"},
                    new Customer {CustomerId = "DRACD", CompanyName = "Drachenblut Delikatessen", Country = "Germany"},
                    new Customer {CustomerId = "DUMON", CompanyName = "Du monde entier", Country = "France"},
                    new Customer {CustomerId = "EASTC", CompanyName = "Eastern Connection", Country = "UK"},
                    new Customer {CustomerId = "ERNSH", CompanyName = "Ernst Handel", Country = "Austria"},
                    new Customer {CustomerId = "FAMIA", CompanyName = "Familia Arquibaldo", Country = "Brazil"},
                    new Customer
                        {
                            CustomerId = "FISSA",
                            CompanyName = "FISSA Fabrica Inter. Salchichas S.A.",
                            Country = "Spain"
                        },
                    new Customer {CustomerId = "FOLIG", CompanyName = "Folies gourmandes", Country = "France"},
                    new Customer {CustomerId = "FOLKO", CompanyName = "Folk och fä HB", Country = "Sweden"},
                    new Customer {CustomerId = "FRANK", CompanyName = "Frankenversand", Country = "Germany"},
                    new Customer {CustomerId = "FRANR", CompanyName = "France restauration", Country = "France"},
                    new Customer {CustomerId = "FRANS", CompanyName = "Franchi S.p.A.", Country = "Italy"},
                    new Customer
                        {
                            CustomerId = "FURIB",
                            CompanyName = "Furia Bacalhau e Frutos do Mar",
                            Country = "Portugal"
                        },
                    new Customer {CustomerId = "GALED", CompanyName = "Galería del gastrónomo", Country = "Spain"},
                    new Customer {CustomerId = "GODOS", CompanyName = "Godos Cocina Típica", Country = "Spain"},
                    new Customer {CustomerId = "GOURL", CompanyName = "Gourmet Lanchonetes", Country = "Brazil"},
                    new Customer {CustomerId = "GREAL", CompanyName = "Great Lakes Food Market", Country = "USA"},
                    new Customer {CustomerId = "GROSR", CompanyName = "GROSELLA-Restaurante", Country = "Venezuela"},
                    new Customer {CustomerId = "HANAR", CompanyName = "Hanari Carnes", Country = "Brazil"},
                    new Customer {CustomerId = "HILAA", CompanyName = "HILARION-Abastos", Country = "Venezuela"},
                    new Customer {CustomerId = "HUNGC", CompanyName = "Hungry Coyote Import Store", Country = "USA"},
                    new Customer
                        {
                            CustomerId = "HUNGO",
                            CompanyName = "Hungry Owl All-Night Grocers",
                            Country = "Ireland"
                        },
                    new Customer {CustomerId = "ISLAT", CompanyName = "Island Trading", Country = "UK"},
                    new Customer {CustomerId = "KOENE", CompanyName = "Königlich Essen", Country = "Germany"},
                    new Customer {CustomerId = "LACOR", CompanyName = "La corne d'abondance", Country = "France"},
                    new Customer {CustomerId = "LAMAI", CompanyName = "La maison d'Asie", Country = "France"},
                    new Customer
                        {
                            CustomerId = "LAUGB",
                            CompanyName = "Laughing Bacchus Wine Cellars",
                            Country = "Canada"
                        },
                    new Customer {CustomerId = "LAZYK", CompanyName = "Lazy K Kountry Store", Country = "USA"},
                    new Customer {CustomerId = "LEHMS", CompanyName = "Lehmanns Marktstand", Country = "Germany"},
                    new Customer {CustomerId = "LETSS", CompanyName = "Let's Stop N Shop", Country = "USA"},
                    new Customer {CustomerId = "LILAS", CompanyName = "LILA-Supermercado", Country = "Venezuela"},
                    new Customer {CustomerId = "LINOD", CompanyName = "LINO-Delicateses", Country = "Venezuela"},
                    new Customer {CustomerId = "LONEP", CompanyName = "Lonesome Pine Restaurant", Country = "USA"},
                    new Customer {CustomerId = "MAGAA", CompanyName = "Magazzini Alimentari Riuniti", Country = "Italy"},
                    new Customer {CustomerId = "MAISD", CompanyName = "Maison Dewey", Country = "Belgium"},
                    new Customer {CustomerId = "MEREP", CompanyName = "Mère Paillarde", Country = "Canada"},
                    new Customer {CustomerId = "MORGK", CompanyName = "Morgenstern Gesundkost", Country = "Germany"},
                    new Customer {CustomerId = "NORTS", CompanyName = "North/South", Country = "UK"},
                    new Customer {CustomerId = "OCEAN", CompanyName = "Océano Atlántico Ltda.", Country = "Argentina"},
                    new Customer {CustomerId = "OLDWO", CompanyName = "Old World Delicatessen", Country = "USA"},
                    new Customer {CustomerId = "OTTIK", CompanyName = "Ottilies Käseladen", Country = "Germany"},
                    new Customer {CustomerId = "PARIS", CompanyName = "Paris spécialités", Country = "France"},
                    new Customer {CustomerId = "PERIC", CompanyName = "Pericles Comidas clásicas", Country = "Mexico"},
                    new Customer {CustomerId = "PICCO", CompanyName = "Piccolo und mehr", Country = "Austria"},
                    new Customer {CustomerId = "PRINI", CompanyName = "Princesa Isabel Vinhos", Country = "Portugal"},
                    new Customer {CustomerId = "QUEDE", CompanyName = "Que Delícia", Country = "Brazil"},
                    new Customer {CustomerId = "QUEEN", CompanyName = "Queen Cozinha", Country = "Brazil"},
                    new Customer {CustomerId = "QUICK", CompanyName = "QUICK-Stop", Country = "Germany"},
                    new Customer {CustomerId = "RANCH", CompanyName = "Rancho grande", Country = "Argentina"},
                    new Customer {CustomerId = "RATTC", CompanyName = "Rattlesnake Canyon Grocery", Country = "USA"},
                    new Customer {CustomerId = "REGGC", CompanyName = "Reggiani Caseifici", Country = "Italy"},
                    new Customer {CustomerId = "RICAR", CompanyName = "Ricardo Adocicados", Country = "Brazil"},
                    new Customer {CustomerId = "RICSU", CompanyName = "Richter Supermarkt", Country = "Switzerland"},
                    new Customer {CustomerId = "ROMEY", CompanyName = "Romero y tomillo", Country = "Spain"},
                    new Customer {CustomerId = "SANTG", CompanyName = "Santé Gourmet", Country = "Norway"},
                    new Customer {CustomerId = "SAVEA", CompanyName = "Save-a-lot Markets", Country = "USA"},
                    new Customer {CustomerId = "SEVES", CompanyName = "Seven Seas Imports", Country = "UK"},
                    new Customer {CustomerId = "SIMOB", CompanyName = "Simons bistro", Country = "Denmark"},
                    new Customer {CustomerId = "SPECD", CompanyName = "Spécialités du monde", Country = "France"},
                    new Customer {CustomerId = "SPLIR", CompanyName = "Split Rail Beer & Ale", Country = "USA"},
                    new Customer {CustomerId = "SUPRD", CompanyName = "Suprêmes délices", Country = "Belgium"},
                    new Customer {CustomerId = "THEBI", CompanyName = "The Big Cheese", Country = "USA"},
                    new Customer {CustomerId = "THECR", CompanyName = "The Cracker Box", Country = "USA"},
                    new Customer {CustomerId = "TOMSP", CompanyName = "Toms Spezialitäten", Country = "Germany"},
                    new Customer {CustomerId = "TORTU", CompanyName = "Tortuga Restaurante", Country = "Mexico"},
                    new Customer {CustomerId = "TRADH", CompanyName = "Tradição Hipermercados", Country = "Brazil"},
                    new Customer
                        {
                            CustomerId = "TRAIH",
                            CompanyName = "Trail's Head Gourmet Provisioners",
                            Country = "USA"
                        },
                    new Customer {CustomerId = "VAFFE", CompanyName = "Vaffeljernet", Country = "Denmark"},
                    new Customer {CustomerId = "VICTE", CompanyName = "Victuailles en stock", Country = "France"},
                    new Customer {CustomerId = "VINET", CompanyName = "Vins et alcools Chevalier", Country = "France"},
                    new Customer {CustomerId = "WANDK", CompanyName = "Die Wandernde Kuh", Country = "Germany"},
                    new Customer {CustomerId = "WARTH", CompanyName = "Wartian Herkku", Country = "Finland"},
                    new Customer {CustomerId = "WELLI", CompanyName = "Wellington Importadora", Country = "Brazil"},
                    new Customer {CustomerId = "WHITC", CompanyName = "White Clover Markets", Country = "USA"},
                    new Customer {CustomerId = "WILMK", CompanyName = "Wilman Kala", Country = "Finland"},
                    new Customer {CustomerId = "WOLZA", CompanyName = "Wolski  Zajazd", Country = "Poland"}
                };
        }
    }
}