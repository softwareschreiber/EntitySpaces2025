//======================================
// Copyright EntitySpaces, LLC 2005 - 2006 
//======================================

using System;
using System.Data;
using NUnit.Framework;

using EntitySpaces.Interfaces;
using BusinessObjects;

namespace Tests.Base
{
    [TestFixture]
    public class ConcurrencyFixture
    {
        [Test]
        public void ConcurrencyOnUpdate()
        {
            ConcurrencyTestCollection collection = new ConcurrencyTestCollection();

            switch (collection.es.Connection.ProviderSignature.DataProviderName)
            {
                case "EntitySpaces.SqlServerCeProvider":
                case "EntitySpaces.SqlServerCe4Provider":
                    Assert.Ignore("Not implemented for SqlCe");
                    break;

                default:
                    try
                    {
                        using (esTransactionScope scope = new esTransactionScope())
                        {
                            // Setup
                            ConcurrencyTest entity = new ConcurrencyTest();
                            if (entity.LoadByPrimaryKey("abc"))
                            {
                                entity.MarkAsDeleted();
                                entity.Save();
                            }

                            entity = new ConcurrencyTest();
                            entity.Id = "abc";
                            entity.Name = "Test 1";
                            entity.Save();

                            // Test
                            entity = new ConcurrencyTest();
                            entity.LoadByPrimaryKey("abc");
                            Assert.That(entity.ConcurrencyCheck, Is.EqualTo(1), "Check 1");
                            entity.Name = "Test 2";
                            entity.Save();

                            entity = new ConcurrencyTest();
                            entity.LoadByPrimaryKey("abc");
                            Assert.That(entity.ConcurrencyCheck, Is.EqualTo(2), "Check 2");
                            entity.Name = "Test 3";
                            entity.Save();

                            entity = new ConcurrencyTest();
                            entity.LoadByPrimaryKey("abc");
                            Assert.That(entity.ConcurrencyCheck, Is.EqualTo(3), "Check 3");
                            entity.Name = "Test 4";

                            ConcurrencyTest entity2 = new ConcurrencyTest();
                            entity2.LoadByPrimaryKey("abc");
                            entity2.Name = "Collision";

                            entity.Save();
                            entity2.Save();
                            Assert.Fail("Concurrency Exception not thrown.");
                        }
                    }
                    catch (EntitySpaces.Interfaces.esConcurrencyException cex)
                    {
                        switch (collection.es.Connection.ProviderSignature.DataProviderName)
                        {
                            case "EntitySpaces.MSAccessProvider":
                            case "EntitySpaces.MySqlClientProvider":
                            case "EntitySpaces.SQLiteProvider":
                            case "EntitySpaces.SqlServerCeProvider":
                            case "EntitySpaces.SybaseSqlAnywhereProvider":
                            case "EntitySpaces.VistaDBProvider":
                            case "EntitySpaces.VistaDB4Provider":
                                Assert.That(cex.Message.Substring(0, 8), Is.EqualTo("Error in"));
                                break;

                            case "EntitySpaces.OracleClientProvider":
                                Assert.That(cex.Message.Substring(0, 9), Is.EqualTo("ORA-20101"));
                                break;

                            default:
                                Assert.That(cex.Message.Substring(0, 13), Is.EqualTo("Update failed"));
                                break;
                        }
                    }
                    finally
                    {
                        // Clean up
                        ConcurrencyTest entity = new ConcurrencyTest();
                        if (entity.LoadByPrimaryKey("abc"))
                        {
                            entity.MarkAsDeleted();
                            entity.Save();
                        }
                    }
                    break;
            }
        }

        [Test]
        public void ConcurrencyOnUpdateAutoKey()
        {
            long oldKey = -1;
            ConcurrencyTestChildCollection collection = new ConcurrencyTestChildCollection();

            switch (collection.es.Connection.ProviderSignature.DataProviderName)
            {
                case "EntitySpaces.SqlServerCeProvider":
                case "EntitySpaces.SqlServerCe4Provider":
                    Assert.Ignore("Not implemented for SqlCe");
                    break;

                default:
                    try
                    {
                        using (esTransactionScope scope = new esTransactionScope())
                        {
                            // Setup
                            ConcurrencyTestChild entity = new ConcurrencyTestChild();
                            entity.Name = "Test 1";
                            entity.DefaultTest = Convert.ToDateTime("2010-01-01");
                            entity.Save();
                            oldKey = entity.Id.Value;

                            // Test
                            entity = new ConcurrencyTestChild();
                            entity.LoadByPrimaryKey(oldKey);
                            Assert.That(entity.ConcurrencyCheck, Is.EqualTo(1), "Check 1");
                            entity.Name = "Test 2";
                            entity.Save();

                            entity = new ConcurrencyTestChild();
                            entity.LoadByPrimaryKey(oldKey);
                            Assert.That(entity.ConcurrencyCheck, Is.EqualTo(2), "Check 2");
                            entity.Name = "Test 3";
                            entity.Save();

                            entity = new ConcurrencyTestChild();
                            entity.LoadByPrimaryKey(oldKey);
                            Assert.That(entity.ConcurrencyCheck, Is.EqualTo(3), "Check 3");
                            entity.Name = "Test 4";

                            ConcurrencyTestChild entity2 = new ConcurrencyTestChild();
                            entity2.LoadByPrimaryKey(oldKey);
                            entity2.Name = "Collision";

                            entity.Save();
                            entity2.Save();
                            Assert.Fail("Concurrency Exception not thrown.");
                        }
                    }
                    catch (EntitySpaces.Interfaces.esConcurrencyException cex)
                    {
                        switch (collection.es.Connection.ProviderSignature.DataProviderName)
                        {
                            case "EntitySpaces.MSAccessProvider":
                            case "EntitySpaces.MySqlClientProvider":
                            case "EntitySpaces.SQLiteProvider":
                            case "EntitySpaces.SqlServerCeProvider":
                            case "EntitySpaces.SybaseSqlAnywhereProvider":
                            case "EntitySpaces.VistaDBProvider":
                            case "EntitySpaces.VistaDB4Provider":
                                Assert.That(cex.Message.Substring(0, 8), Is.EqualTo("Error in"));
                                break;

                            case "EntitySpaces.OracleClientProvider":
                                Assert.That(cex.Message.Substring(0, 9), Is.EqualTo("ORA-20101"));
                                break;

                            default:
                                Assert.That(cex.Message.Substring(0, 13), Is.EqualTo("Update failed"));
                                break;
                        }
                    }
                    finally
                    {
                        // Clean up
                        ConcurrencyTestChild entity = new ConcurrencyTestChild();
                        if (entity.LoadByPrimaryKey(oldKey))
                        {
                            entity.MarkAsDeleted();
                            entity.Save();
                        }
                    }
                    break;
            }
        }

        [Test]
        public void ConcurrencyOnDelete()
        {
            ConcurrencyTestCollection collection = new ConcurrencyTestCollection();

            switch (collection.es.Connection.ProviderSignature.DataProviderName)
            {
                case "EntitySpaces.SqlServerCeProvider":
                case "EntitySpaces.SqlServerCe4Provider":
                    Assert.Ignore("Not implemented for SqlCe");
                    break;

                default:
                    try
                    {
                        using (esTransactionScope scope = new esTransactionScope())
                        {
                            // Setup
                            ConcurrencyTest entity = new ConcurrencyTest();
                            if (entity.LoadByPrimaryKey("abc"))
                            {
                                entity.MarkAsDeleted();
                                entity.Save();
                            }

                            entity = new ConcurrencyTest();
                            entity.Id = "abc";
                            entity.Name = "Test 1";
                            entity.Save();

                            // Test
                            entity = new ConcurrencyTest();
                            entity.LoadByPrimaryKey("abc");
                            entity.MarkAsDeleted();

                            ConcurrencyTest entity2 = new ConcurrencyTest();
                            entity2.LoadByPrimaryKey("abc");
                            entity2.MarkAsDeleted();

                            entity.Save();
                            entity2.Save();
                            Assert.Fail("Concurrency Exception not thrown.");
                        }
                    }
                    catch (EntitySpaces.Interfaces.esConcurrencyException cex)
                    {
                        switch (collection.es.Connection.ProviderSignature.DataProviderName)
                        {
                            case "EntitySpaces.MSAccessProvider":
                            case "EntitySpaces.MySqlClientProvider":
                            case "EntitySpaces.SQLiteProvider":
                            case "EntitySpaces.SqlServerCeProvider":
                            case "EntitySpaces.SybaseSqlAnywhereProvider":
                            case "EntitySpaces.VistaDBProvider":
                            case "EntitySpaces.VistaDB4Provider":
                                Assert.That(cex.Message.Substring(0, 8), Is.EqualTo("Error in"));
                                break;

                            case "EntitySpaces.OracleClientProvider":
                                Assert.That(cex.Message.Substring(0, 9), Is.EqualTo("ORA-20101"));
                                break;

                            default:
                                Assert.That(cex.Message.Substring(0, 13), Is.EqualTo("Update failed"));
                                break;
                        }
                    }
                    finally
                    {
                        // Cleanup
                        ConcurrencyTest entity = new ConcurrencyTest();
                        if (entity.LoadByPrimaryKey("abc"))
                        {
                            entity.MarkAsDeleted();
                            entity.Save();
                        }
                    }
                    break;
            }
        }

        [Test]
        public void ConcurrencyOnDeleteAutoKey()
        {
            long oldKey = -1;
            ConcurrencyTestChildCollection collection = new ConcurrencyTestChildCollection();
            ConcurrencyTestChild entity = new ConcurrencyTestChild();

            switch (collection.es.Connection.ProviderSignature.DataProviderName)
            {
                case "EntitySpaces.SqlServerCeProvider":
                case "EntitySpaces.SqlServerCe4Provider":
                    Assert.Ignore("Not implemented for SqlCe");
                    break;

                default:
                    try
                    {
                        using (esTransactionScope scope = new esTransactionScope())
                        {
                            // Setup
                            collection.LoadAll();
                            collection.MarkAllAsDeleted();
                            collection.Save();

                            entity.Name = "Test 1";
                            entity.DefaultTest = Convert.ToDateTime("2010-01-01");
                            entity.Save();
                            oldKey = entity.Id.Value;

                            // Test
                            entity = new ConcurrencyTestChild();
                            entity.LoadByPrimaryKey(oldKey);
                            entity.MarkAsDeleted();

                            ConcurrencyTestChild entity2 = new ConcurrencyTestChild();
                            entity2.LoadByPrimaryKey(oldKey);
                            entity2.MarkAsDeleted();

                            entity.Save();
                            entity2.Save();
                            Assert.Fail("Concurrency Exception not thrown.");
                        }
                    }
                    catch (EntitySpaces.Interfaces.esConcurrencyException cex)
                    {
                        switch (collection.es.Connection.ProviderSignature.DataProviderName)
                        {
                            case "EntitySpaces.MSAccessProvider":
                            case "EntitySpaces.MySqlClientProvider":
                            case "EntitySpaces.SQLiteProvider":
                            case "EntitySpaces.SqlServerCeProvider":
                            case "EntitySpaces.SybaseSqlAnywhereProvider":
                            case "EntitySpaces.VistaDBProvider":
                            case "EntitySpaces.VistaDB4Provider":
                                Assert.That(cex.Message.Substring(0, 8), Is.EqualTo("Error in"));
                                break;

                            case "EntitySpaces.OracleClientProvider":
                                Assert.That(cex.Message.Substring(0, 9), Is.EqualTo("ORA-20101"));
                                break;

                            default:
                                Assert.That(cex.Message.Substring(0, 13), Is.EqualTo("Update failed"));
                                break;
                        }
                    }
                    finally
                    {
                        // Cleanup
                        entity = new ConcurrencyTestChild();
                        if (entity.LoadByPrimaryKey(oldKey))
                        {
                            entity.MarkAsDeleted();
                            entity.Save();
                        }
                    }
                    break;
            }
        }

        [Test]
        public void ConcurrencyOnUpdateDelete()
        {
            ConcurrencyTestCollection collection = new ConcurrencyTestCollection();

            switch (collection.es.Connection.ProviderSignature.DataProviderName)
            {
                case "EntitySpaces.SqlServerCeProvider":
                case "EntitySpaces.SqlServerCe4Provider":
                    Assert.Ignore("Not implemented for SqlCe");
                    break;

                default:
                    try
                    {
                        using (esTransactionScope scope = new esTransactionScope())
                        {
                            // Setup
                            ConcurrencyTest entity = new ConcurrencyTest();
                            if (entity.LoadByPrimaryKey("abc"))
                            {
                                entity.MarkAsDeleted();
                                entity.Save();
                            }

                            entity = new ConcurrencyTest();
                            entity.Id = "abc";
                            entity.Name = "Test 1";
                            entity.Save();

                            // Test
                            entity = new ConcurrencyTest();
                            entity.LoadByPrimaryKey("abc");
                            entity.Name = "Test 2";

                            ConcurrencyTest entity2 = new ConcurrencyTest();
                            entity2.LoadByPrimaryKey("abc");
                            entity2.MarkAsDeleted();

                            entity.Save();
                            entity2.Save();
                            Assert.Fail("Concurrency Exception not thrown.");
                        }
                    }
                    catch (EntitySpaces.Interfaces.esConcurrencyException cex)
                    {
                        switch (collection.es.Connection.ProviderSignature.DataProviderName)
                        {
                            case "EntitySpaces.MSAccessProvider":
                            case "EntitySpaces.MySqlClientProvider":
                            case "EntitySpaces.SQLiteProvider":
                            case "EntitySpaces.SqlServerCeProvider":
                            case "EntitySpaces.SybaseSqlAnywhereProvider":
                            case "EntitySpaces.VistaDBProvider":
                            case "EntitySpaces.VistaDB4Provider":
                                Assert.That(cex.Message.Substring(0, 8), Is.EqualTo("Error in"));
                                break;

                            case "EntitySpaces.OracleClientProvider":
                                Assert.That(cex.Message.Substring(0, 9), Is.EqualTo("ORA-20101"));
                                break;

                            default:
                                Assert.That(cex.Message.Substring(0, 13), Is.EqualTo("Update failed"));
                                break;
                        }
                    }
                    finally
                    {
                        // Cleanup
                        ConcurrencyTest entity = new ConcurrencyTest();
                        if (entity.LoadByPrimaryKey("abc"))
                        {
                            entity.MarkAsDeleted();
                            entity.Save();
                        }
                    }
                    break;
            }
        }

        [Test]
        public void ConcurrencyOnUpdateDeleteAutoKey()
        {
            long oldKey = -1;
            ConcurrencyTestChildCollection collection = new ConcurrencyTestChildCollection();

            switch (collection.es.Connection.ProviderSignature.DataProviderName)
            {
                case "EntitySpaces.SqlServerCeProvider":
                case "EntitySpaces.SqlServerCe4Provider":
                    Assert.Ignore("Not implemented for SqlCe");
                    break;

                default:
                    try
                    {
                        using (esTransactionScope scope = new esTransactionScope())
                        {
                            // Setup
                            ConcurrencyTestChild entity = new ConcurrencyTestChild();
                            entity.Name = "Test 1";
                            entity.DefaultTest = Convert.ToDateTime("2010-01-01");
                            entity.Save();
                            oldKey = entity.Id.Value;

                            // Test
                            entity = new ConcurrencyTestChild();
                            entity.LoadByPrimaryKey(oldKey);
                            entity.Name = "Test 2";

                            ConcurrencyTestChild entity2 = new ConcurrencyTestChild();
                            entity2.LoadByPrimaryKey(oldKey);
                            entity2.MarkAsDeleted();

                            entity.Save();
                            entity2.Save();
                            Assert.Fail("Concurrency Exception not thrown.");
                        }
                    }
                    catch (EntitySpaces.Interfaces.esConcurrencyException cex)
                    {
                        switch (collection.es.Connection.ProviderSignature.DataProviderName)
                        {
                            case "EntitySpaces.MSAccessProvider":
                            case "EntitySpaces.MySqlClientProvider":
                            case "EntitySpaces.SQLiteProvider":
                            case "EntitySpaces.SqlServerCeProvider":
                            case "EntitySpaces.SybaseSqlAnywhereProvider":
                            case "EntitySpaces.VistaDBProvider":
                            case "EntitySpaces.VistaDB4Provider":
                                Assert.That(cex.Message.Substring(0, 8), Is.EqualTo("Error in"));
                                break;

                            case "EntitySpaces.OracleClientProvider":
                                Assert.That(cex.Message.Substring(0, 9), Is.EqualTo("ORA-20101"));
                                break;

                            default:
                                Assert.That(cex.Message.Substring(0, 13), Is.EqualTo("Update failed"));
                                break;
                        }
                    }
                    finally
                    {
                        // Cleanup
                        ConcurrencyTestChild entity = new ConcurrencyTestChild();
                        if (entity.LoadByPrimaryKey(oldKey))
                        {
                            entity.MarkAsDeleted();
                            entity.Save();
                        }
                    }
                    break;
            }
        }

    }
}
