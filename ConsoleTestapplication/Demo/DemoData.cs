using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Timekeeper.Models.DataModels;

namespace ConsoleTestapplication.Demo
{
    public static class DemoData
    {
        public static void AddData(HttpClient client)
        {
            var persons = CreatePersons();
            Tests.PersonTest.InsertItems(persons, client);

            var resources = CreateResource();
            Tests.ResourceTest.InsertItems(resources, client);

            var projects = CreateProjects();
            Tests.ProjectTest.InsertItems(projects, client);

            var customerLocations = CreateCustomerLocations();
            Tests.LocationTest.InsertItems(customerLocations, client);


            var contracts = CreateCustomerContracts();
            Tests.ContractTest.InsertItems(contracts, client);

            var customers = CreateCustomer();
            Tests.CustomerTest.InsertItems(customers, client);

            var bookings = CreateBookings();
            Tests.BookingsTest.InsertItems(bookings, client);
        }

        public static void DeleteData(HttpClient client)
        {
            var persons = CreatePersons();
            Tests.PersonTest.DeleteItems(persons, client);

            var resources = CreateResource();
            Tests.ResourceTest.DeleteItems(resources, client);

            var projects = CreateProjects();
            Tests.ProjectTest.DeleteItems(projects, client);

            var customerLocations = CreateCustomerLocations();
            Tests.LocationTest.DeleteItems(customerLocations, client);


            var contracts = CreateCustomerContracts();
            Tests.ContractTest.DeleteItems(contracts, client);

            var customers = CreateCustomer();
            Tests.CustomerTest.DeleteItems(customers, client);
        }

        private static List<Resource> CreateResource()
        {
            List<Resource> lstResource = new List<Resource>();
            lstResource.Add(new Resource() { ID = new Guid("c2922812-5d30-4023-8f7e-783173cffcc9"), Person = new Guid("dc9050ab-e9a9-4d48-a9b2-6d3a1e4ce5e3"), Project = new Guid("0d8d1d53-67a8-42a4-874f-740b7b403ed0"), StartDate = new DateTime(2018, 01, 01), EndDate = new DateTime(2019, 01, 01), RequestedHours = 30, ResourceRole = "Consultant" });
            lstResource.Add(new Resource() { ID = new Guid("f3495ada-f7f6-4c53-9e64-ec367142d12b"), Person = new Guid("cc519771-951b-4ee7-b3d7-2e8229ce45ba"), Project = new Guid("192f6683-eec7-41fa-869a-0aa5239d3bda"), StartDate = new DateTime(2018, 01, 01), EndDate = new DateTime(2019, 01, 01), RequestedHours = 60, ResourceRole = "PFE" });
            lstResource.Add(new Resource() { ID = new Guid("b3c67158-3d60-49f4-bb5a-087168009fbb"), Person = new Guid("5fe7c14f-965e-454d-b061-26fd66f3a3a5"), Project = new Guid("0661f809-35a6-4bc5-87e7-27b1866c2a74"), StartDate = new DateTime(2018, 01, 01), EndDate = new DateTime(2019, 01, 01), RequestedHours = 130, ResourceRole = "Project Manager" });
            lstResource.Add(new Resource() { ID = new Guid("0211d5d9-375d-4758-9762-c398db0872c2"), Person = new Guid("2fc929ae-298c-442a-910a-bd99184811d4"), Project = new Guid("480a1213-e846-4246-9721-d2eb77808ffc"), StartDate = new DateTime(2018, 01, 01), EndDate = new DateTime(2019, 01, 01), RequestedHours = 230, ResourceRole = "Architekt" });

            lstResource.Add(new Resource() { ID = new Guid("f89361a1-1db5-493d-a56d-603f6492e6bf"), Person = new Guid("dc9050ab-e9a9-4d48-a9b2-6d3a1e4ce5e3"), Project = new Guid("f1bfccf7-f0b1-45e5-88cc-0fb4f8862ff5"), StartDate = new DateTime(2018, 02, 01), EndDate = new DateTime(2019, 02, 01), RequestedHours = 90, ResourceRole = "Consultant" });
            lstResource.Add(new Resource() { ID = new Guid("37480890-d8bc-412f-be77-fd120cc2bea2"), Person = new Guid("cc519771-951b-4ee7-b3d7-2e8229ce45ba"), Project = new Guid("32a23acd-2abd-4bb9-b391-23f74a714557"), StartDate = new DateTime(2018, 02, 01), EndDate = new DateTime(2019, 02, 01), RequestedHours = 20, ResourceRole = "PFE" });
            lstResource.Add(new Resource() { ID = new Guid("8748fcc1-defe-4b67-b920-b8b50e14949e"), Person = new Guid("5fe7c14f-965e-454d-b061-26fd66f3a3a5"), Project = new Guid("66a5a348-5deb-4616-9c0a-10d062d6b54c"), StartDate = new DateTime(2018, 02, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 50, ResourceRole = "Project Manager" });
            lstResource.Add(new Resource() { ID = new Guid("4b82c170-0fce-4a6b-a0bf-9ce88be2b010"), Person = new Guid("2fc929ae-298c-442a-910a-bd99184811d4"), Project = new Guid("db52b28c-d8f4-42a3-b082-108408134891"), StartDate = new DateTime(2018, 02, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 70, ResourceRole = "Architekt" });
                                                                                                    
            lstResource.Add(new Resource() { ID = new Guid("b1f0dfa6-8795-4427-8613-3d59a7b0e963"), Person = new Guid("941905b1-2376-40d1-9332-0eb35f5e2d65"), Project = new Guid("3dead4b4-a935-4620-9ec8-ade32cf59caa"), StartDate = new DateTime(2018, 03, 01), EndDate = new DateTime(2019, 03, 01), RequestedHours = 80, ResourceRole = "Consultant" });
            lstResource.Add(new Resource() { ID = new Guid("ba077b48-f345-4dc5-bb6d-33c5c8b40ae1"), Person = new Guid("cc519771-951b-4ee7-b3d7-2e8229ce45ba"), Project = new Guid("1835d97c-51c4-4823-81da-4a696a151dad"), StartDate = new DateTime(2018, 03, 01), EndDate = new DateTime(2019, 03, 01), RequestedHours = 100, ResourceRole = "PFE" });
            lstResource.Add(new Resource() { ID = new Guid("a9ff54c4-1b92-4c6c-8244-e1a815c686cb"), Person = new Guid("5fe7c14f-965e-454d-b061-26fd66f3a3a5"), Project = new Guid("55c5628c-adbf-45a4-9d0c-3198abe5614b"), StartDate = new DateTime(2018, 03, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 300, ResourceRole = "Project Manager" });
            lstResource.Add(new Resource() { ID = new Guid("744ccc88-99b9-43f9-b6d3-44b3df564c98"), Person = new Guid("2fc929ae-298c-442a-910a-bd99184811d4"), Project = new Guid("739105de-b404-41ec-8da3-546790ee8b43"), StartDate = new DateTime(2018, 03, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 10, ResourceRole = "Architekt" });

            lstResource.Add(new Resource() { ID = new Guid("9dad5c79-6556-43e1-b297-304ae17f489d"), Person = new Guid("941905b1-2376-40d1-9332-0eb35f5e2d65"), Project = new Guid("c2bcc33a-ab7f-45d1-b33d-57fcdf385fc8"), StartDate = new DateTime(2018, 04, 01), EndDate = new DateTime(2019, 04, 01), RequestedHours = 30, ResourceRole = "PFE" });
            lstResource.Add(new Resource() { ID = new Guid("b20a939b-4e64-4f66-97b8-26c208cb230e"), Person = new Guid("dc9050ab-e9a9-4d48-a9b2-6d3a1e4ce5e3"), Project = new Guid("1274ef80-04b2-4905-9776-99df5af0846b"), StartDate = new DateTime(2018, 04, 01), EndDate = new DateTime(2019, 04, 01), RequestedHours = 80, ResourceRole = "Consultant" });
            lstResource.Add(new Resource() { ID = new Guid("0e3acd66-f178-4c0d-8c46-cdd6c523603b"), Person = new Guid("cc519771-951b-4ee7-b3d7-2e8229ce45ba"), Project = new Guid("6d696082-1f4a-4128-b440-2ee4c62182a6"), StartDate = new DateTime(2018, 04, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 60, ResourceRole = "Project Manager" });
            lstResource.Add(new Resource() { ID = new Guid("32bee55a-b33b-4308-a4e6-76f1dd630974"), Person = new Guid("941905b1-2376-40d1-9332-0eb35f5e2d65"), Project = new Guid("7bd2cd8d-db9d-479c-bb2c-d2550b26ab81"), StartDate = new DateTime(2018, 04, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 20, ResourceRole = "Architekt" });

            lstResource.Add(new Resource() { ID = new Guid("249798e1-13ca-4cf9-b7c3-f606af1c30f4"), Person = new Guid("dc9050ab-e9a9-4d48-a9b2-6d3a1e4ce5e3"), Project = new Guid("05255478-5976-479d-aaba-7757802bc0cc"), StartDate = new DateTime(2018, 05, 01), EndDate = new DateTime(2019, 05, 01), RequestedHours = 20, ResourceRole = "Consultant" });
            lstResource.Add(new Resource() { ID = new Guid("39f39733-0099-4b90-9a33-b1863a791688"), Person = new Guid("cc519771-951b-4ee7-b3d7-2e8229ce45ba"), Project = new Guid("40395acd-819f-4b4c-b684-ad74db85b3ca"), StartDate = new DateTime(2018, 05, 01), EndDate = new DateTime(2019, 05, 01), RequestedHours = 10, ResourceRole = "PFE" });
            lstResource.Add(new Resource() { ID = new Guid("c9297e85-0a57-4b2d-96e8-bbd5711feef6"), Person = new Guid("5fe7c14f-965e-454d-b061-26fd66f3a3a5"), Project = new Guid("a32eb050-5b01-4cd6-a55b-282d718c8cba"), StartDate = new DateTime(2018, 05, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 90, ResourceRole = "Project Manager" });
            lstResource.Add(new Resource() { ID = new Guid("448942ef-dfae-418b-9022-deefaf989fea"), Person = new Guid("2fc929ae-298c-442a-910a-bd99184811d4"), Project = new Guid("9db8404e-80f1-4eb2-8dfd-0d3f1347984a"), StartDate = new DateTime(2018, 05, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 80, ResourceRole = "Architekt" });
                                                                                                            
            lstResource.Add(new Resource() { ID = new Guid("e4d8243d-2ed1-4f15-895b-042995be8486"), Person = new Guid("dc9050ab-e9a9-4d48-a9b2-6d3a1e4ce5e3"), Project = new Guid("27a5e626-2502-4651-b798-cc1d7c50f063"), StartDate = new DateTime(2018, 06, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 80, ResourceRole = "Consultant" });
            lstResource.Add(new Resource() { ID = new Guid("f5f3a2ca-6d0c-4bd4-8c9f-6b3690cebcd4"), Person = new Guid("cc519771-951b-4ee7-b3d7-2e8229ce45ba"), Project = new Guid("b79c22e8-beb2-4a21-acbc-efa373ee9f41"), StartDate = new DateTime(2018, 06, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 130, ResourceRole = "Consultant" });
            lstResource.Add(new Resource() { ID = new Guid("02aa16c2-280f-403f-8d77-60251ee98fb3"), Person = new Guid("5fe7c14f-965e-454d-b061-26fd66f3a3a5"), Project = new Guid("158f2eec-759a-4c95-8950-98ec1e93b8d7"), StartDate = new DateTime(2018, 06, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 120, ResourceRole = "PFE" });
            lstResource.Add(new Resource() { ID = new Guid("8530e3d2-1148-4bec-9153-40b7c527b6f5"), Person = new Guid("2fc929ae-298c-442a-910a-bd99184811d4"), Project = new Guid("64c39039-3796-4994-9651-ee704201a1db"), StartDate = new DateTime(2018, 06, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 110, ResourceRole = "Architekt" });

            lstResource.Add(new Resource() { ID = new Guid("20d872fc-3243-4770-897f-084cec577af8"), Person = new Guid("941905b1-2376-40d1-9332-0eb35f5e2d65"), Project = new Guid("361164cb-a45f-4c8b-9479-054201e60cc1"), StartDate = new DateTime(2018, 07, 01), EndDate = new DateTime(2019, 07, 01), RequestedHours = 90, ResourceRole = "Architekt" });
            lstResource.Add(new Resource() { ID = new Guid("670a90d9-c071-47f3-b3be-f61a5b08e46d"), Person = new Guid("dc9050ab-e9a9-4d48-a9b2-6d3a1e4ce5e3"), Project = new Guid("d497bb5b-f0e0-4678-a51e-97624521b659"), StartDate = new DateTime(2018, 07, 01), EndDate = new DateTime(2019, 07, 01), RequestedHours = 50, ResourceRole = "PFE" });
            lstResource.Add(new Resource() { ID = new Guid("71c2cf87-322d-4115-9c9a-f224d42d2bbc"), Person = new Guid("cc519771-951b-4ee7-b3d7-2e8229ce45ba"), Project = new Guid("118ca642-e9f3-43e9-9dda-5a602419cf53"), StartDate = new DateTime(2018, 07, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 50, ResourceRole = "PFE" });
            lstResource.Add(new Resource() { ID = new Guid("aec6a5b7-30a0-4139-9b70-5a92bf21b53d"), Person = new Guid("5fe7c14f-965e-454d-b061-26fd66f3a3a5"), Project = new Guid("1f06deb4-7536-4189-ac90-8f6c69d4fda6"), StartDate = new DateTime(2018, 07, 01), EndDate = new DateTime(2019, 06, 01), RequestedHours = 50, ResourceRole = "Consultant" });

            lstResource.Add(new Resource() { ID = new Guid("4353be94-9f3d-4e33-935c-85db75aac0f9"), Person = new Guid("2fc929ae-298c-442a-910a-bd99184811d4"), Project = new Guid("5bf45c74-da78-4d47-b9a5-ee7193f36587"), StartDate = new DateTime(2018, 08, 01), EndDate = new DateTime(2019, 08, 01), RequestedHours = 20, ResourceRole = "Consultant" });
            lstResource.Add(new Resource() { ID = new Guid("a1cf3bc5-f717-413e-b8a1-683ab21a67e2"), Person = new Guid("941905b1-2376-40d1-9332-0eb35f5e2d65"), Project = new Guid("6debfcc0-52dd-4077-8c88-5e791f32b45d"), StartDate = new DateTime(2018, 08, 01), EndDate = new DateTime(2019, 08, 01), RequestedHours = 70, ResourceRole = "Consultant" });

            return lstResource;
        }

        private static List<Person> CreatePersons()
        {
            List<Person> lstPerson = new List<Person>();
            lstPerson.Add(new Person() { ID = new Guid("dc9050ab-e9a9-4d48-a9b2-6d3a1e4ce5e3"), Firstname = "Ralf", Name = "H.", TargetHours = 1000, EMail = "ralf@test.de" });
            lstPerson.Add(new Person() { ID = new Guid("cc519771-951b-4ee7-b3d7-2e8229ce45ba"), Firstname = "Paul", Name = "P.", TargetHours = 1000, EMail = "paul@test.de" });
            lstPerson.Add(new Person() { ID = new Guid("5fe7c14f-965e-454d-b061-26fd66f3a3a5"), Firstname = "Michael", Name = "E.", TargetHours = 1000, EMail = "michael@test.de" });
            lstPerson.Add(new Person() { ID = new Guid("2fc929ae-298c-442a-910a-bd99184811d4"), Firstname = "Denis", Name = "B.", TargetHours = 1000, EMail = "denis@test.de" });
            lstPerson.Add(new Person() { ID = new Guid("941905b1-2376-40d1-9332-0eb35f5e2d65"), Firstname = "Matthias", Name = "T.", TargetHours = 1000, EMail = "matthias@test.de" });

            return lstPerson;
        }

        private static List<Project> CreateProjects()
        {
            List<Project> lstProjects = new List<Project>();

            lstProjects.Add(new Project() { ID = new Guid("0d8d1d53-67a8-42a4-874f-740b7b403ed0"), StartDate = new DateTime(2018, 01, 01), EndDate = new DateTime(2019, 01, 01), Name = "Data Analysis" });
            lstProjects.Add(new Project() { ID = new Guid("192f6683-eec7-41fa-869a-0aa5239d3bda"), StartDate = new DateTime(2018, 01, 01), EndDate = new DateTime(2019, 01, 01), Name = "Support" });
            lstProjects.Add(new Project() { ID = new Guid("0661f809-35a6-4bc5-87e7-27b1866c2a74"), StartDate = new DateTime(2018, 01, 01), EndDate = new DateTime(2019, 06, 01), Name = "Support" });
            lstProjects.Add(new Project() { ID = new Guid("480a1213-e846-4246-9721-d2eb77808ffc"), StartDate = new DateTime(2018, 01, 01), EndDate = new DateTime(2019, 06, 01), Name = "Analysis" });

            lstProjects.Add(new Project() { ID = new Guid("f1bfccf7-f0b1-45e5-88cc-0fb4f8862ff5"), StartDate = new DateTime(2018, 02, 01), EndDate = new DateTime(2019, 02, 01), Name = "Migration Planning" });
            lstProjects.Add(new Project() { ID = new Guid("32a23acd-2abd-4bb9-b391-23f74a714557"), StartDate = new DateTime(2018, 02, 01), EndDate = new DateTime(2019, 02, 01), Name = "Office 365 Support" });
            lstProjects.Add(new Project() { ID = new Guid("66a5a348-5deb-4616-9c0a-10d062d6b54c"), StartDate = new DateTime(2018, 02, 01), EndDate = new DateTime(2019, 06, 01), Name = "Implementation" });
            lstProjects.Add(new Project() { ID = new Guid("db52b28c-d8f4-42a3-b082-108408134891"), StartDate = new DateTime(2018, 02, 01), EndDate = new DateTime(2019, 06, 01), Name = "Development" });

            lstProjects.Add(new Project() { ID = new Guid("3dead4b4-a935-4620-9ec8-ade32cf59caa"), StartDate = new DateTime(2018, 03, 01), EndDate = new DateTime(2019, 03, 01), Name = "Migration" });
            lstProjects.Add(new Project() { ID = new Guid("1835d97c-51c4-4823-81da-4a696a151dad"), StartDate = new DateTime(2018, 03, 01), EndDate = new DateTime(2019, 03, 01), Name = "Data Analysis" });
            lstProjects.Add(new Project() { ID = new Guid("55c5628c-adbf-45a4-9d0c-3198abe5614b"), StartDate = new DateTime(2018, 03, 01), EndDate = new DateTime(2019, 06, 01), Name = "Support" });
            lstProjects.Add(new Project() { ID = new Guid("739105de-b404-41ec-8da3-546790ee8b43"), StartDate = new DateTime(2018, 03, 01), EndDate = new DateTime(2019, 06, 01), Name = "Support" });

            lstProjects.Add(new Project() { ID = new Guid("c2bcc33a-ab7f-45d1-b33d-57fcdf385fc8"), StartDate = new DateTime(2018, 04, 01), EndDate = new DateTime(2019, 04, 01), Name = "Support" });
            lstProjects.Add(new Project() { ID = new Guid("1274ef80-04b2-4905-9776-99df5af0846b"), StartDate = new DateTime(2018, 04, 01), EndDate = new DateTime(2019, 04, 01), Name = "Support" });
            lstProjects.Add(new Project() { ID = new Guid("6d696082-1f4a-4128-b440-2ee4c62182a6"), StartDate = new DateTime(2018, 04, 01), EndDate = new DateTime(2019, 06, 01), Name = "Azure Planning" });
            lstProjects.Add(new Project() { ID = new Guid("7bd2cd8d-db9d-479c-bb2c-d2550b26ab81"), StartDate = new DateTime(2018, 04, 01), EndDate = new DateTime(2019, 06, 01), Name = "Support" });

            lstProjects.Add(new Project() { ID = new Guid("05255478-5976-479d-aaba-7757802bc0cc"), StartDate = new DateTime(2018, 05, 01), EndDate = new DateTime(2019, 05, 01), Name = "Migration Planning" });
            lstProjects.Add(new Project() { ID = new Guid("40395acd-819f-4b4c-b684-ad74db85b3ca"), StartDate = new DateTime(2018, 05, 01), EndDate = new DateTime(2019, 05, 01), Name = "Azure Integration" });
            lstProjects.Add(new Project() { ID = new Guid("a32eb050-5b01-4cd6-a55b-282d718c8cba"), StartDate = new DateTime(2018, 05, 01), EndDate = new DateTime(2019, 06, 01), Name = "Planning" });
            lstProjects.Add(new Project() { ID = new Guid("9db8404e-80f1-4eb2-8dfd-0d3f1347984a"), StartDate = new DateTime(2018, 05, 01), EndDate = new DateTime(2019, 06, 01), Name = "Support" });

            lstProjects.Add(new Project() { ID = new Guid("27a5e626-2502-4651-b798-cc1d7c50f063"), StartDate = new DateTime(2018, 06, 01), EndDate = new DateTime(2019, 06, 01), Name = "Cognitive Learning/Training" });
            lstProjects.Add(new Project() { ID = new Guid("b79c22e8-beb2-4a21-acbc-efa373ee9f41"), StartDate = new DateTime(2018, 06, 01), EndDate = new DateTime(2019, 06, 01), Name = "Tracking" });
            lstProjects.Add(new Project() { ID = new Guid("158f2eec-759a-4c95-8950-98ec1e93b8d7"), StartDate = new DateTime(2018, 06, 01), EndDate = new DateTime(2019, 06, 01), Name = "Learning / Training" });
            lstProjects.Add(new Project() { ID = new Guid("64c39039-3796-4994-9651-ee704201a1db"), StartDate = new DateTime(2018, 06, 01), EndDate = new DateTime(2019, 06, 01), Name = "Workshops" });

            lstProjects.Add(new Project() { ID = new Guid("361164cb-a45f-4c8b-9479-054201e60cc1"), StartDate = new DateTime(2018, 07, 01), EndDate = new DateTime(2019, 06, 01), Name = "Migration" });
            lstProjects.Add(new Project() { ID = new Guid("d497bb5b-f0e0-4678-a51e-97624521b659"), StartDate = new DateTime(2018, 07, 01), EndDate = new DateTime(2019, 06, 01), Name = "Data Aquirement" });
            lstProjects.Add(new Project() { ID = new Guid("118ca642-e9f3-43e9-9dda-5a602419cf53"), StartDate = new DateTime(2018, 07, 01), EndDate = new DateTime(2019, 06, 01), Name = "Support" });
            lstProjects.Add(new Project() { ID = new Guid("1f06deb4-7536-4189-ac90-8f6c69d4fda6"), StartDate = new DateTime(2018, 07, 01), EndDate = new DateTime(2019, 06, 01), Name = "Requirements Planning" });

            lstProjects.Add(new Project() { ID = new Guid("5bf45c74-da78-4d47-b9a5-ee7193f36587"), StartDate = new DateTime(2018, 08, 01), EndDate = new DateTime(2019, 07, 01), Name = "Development" });
            lstProjects.Add(new Project() { ID = new Guid("6debfcc0-52dd-4077-8c88-5e791f32b45d"), StartDate = new DateTime(2018, 08, 01), EndDate = new DateTime(2019, 07, 01), Name = "Prediction" });
            lstProjects.Add(new Project() { ID = new Guid("bd4f95c7-eca5-4e31-8753-db18a69d640a"), StartDate = new DateTime(2018, 08, 01), EndDate = new DateTime(2019, 06, 01), Name = "Development" });
            lstProjects.Add(new Project() { ID = new Guid("d501350a-32eb-4c77-8ec9-335f1e9f7a7a"), StartDate = new DateTime(2018, 08, 01), EndDate = new DateTime(2019, 06, 01), Name = "Learning / Training" });

            lstProjects.Add(new Project() { ID = new Guid("6ba436ef-c1b3-4604-9654-34a03a257ba0"), StartDate = new DateTime(2018, 09, 01), EndDate = new DateTime(2019, 08, 01), Name = "Support" });
            lstProjects.Add(new Project() { ID = new Guid("65f1d0c2-0950-4134-90b2-370d846afc7b"), StartDate = new DateTime(2018, 09, 01), EndDate = new DateTime(2019, 08, 01), Name = "Workshop" });
            lstProjects.Add(new Project() { ID = new Guid("155e43d4-86b6-4e6d-9f94-c26f97eeb62f"), StartDate = new DateTime(2018, 09, 01), EndDate = new DateTime(2019, 06, 01), Name = "Workshop" });
            lstProjects.Add(new Project() { ID = new Guid("96ac7f07-c10b-4d4b-88af-9abdf1360ef4"), StartDate = new DateTime(2018, 09, 01), EndDate = new DateTime(2019, 06, 01), Name = "Workshop" });

            lstProjects.Add(new Project() { ID = new Guid("9b4a15bf-6d15-4eca-a29e-f923e7a843cf"), StartDate = new DateTime(2018, 10, 01), EndDate = new DateTime(2019, 10, 01), Name = "Development" });
            lstProjects.Add(new Project() { ID = new Guid("997c08ab-5e30-40ba-89f0-f68f1043acb5"), StartDate = new DateTime(2018, 10, 01), EndDate = new DateTime(2019, 10, 01), Name = "Analysis" });
            lstProjects.Add(new Project() { ID = new Guid("3cefd722-ffef-473d-a5a7-3e63809e9378"), StartDate = new DateTime(2018, 10, 01), EndDate = new DateTime(2019, 06, 01), Name = "UAC" });
            lstProjects.Add(new Project() { ID = new Guid("3b1f3899-471d-4cf7-8e32-8b94ed61ea93"), StartDate = new DateTime(2018, 10, 01), EndDate = new DateTime(2019, 06, 01), Name = "Intrusion Detection" });

            lstProjects.Add(new Project() { ID = new Guid("087ee121-1f29-4fc7-a6cc-5302e6eaa5ec"), StartDate = new DateTime(2018, 11, 01), EndDate = new DateTime(2019, 11, 01), Name = "Implementation" });
            lstProjects.Add(new Project() { ID = new Guid("c89c1b8e-9528-48c1-96eb-b94f38ab175b"), StartDate = new DateTime(2018, 11, 01), EndDate = new DateTime(2019, 11, 01), Name = "User Acceptence Test" });
            lstProjects.Add(new Project() { ID = new Guid("6ea2c510-2f99-40a6-a8b6-9f2d8ea13b6c"), StartDate = new DateTime(2018, 11, 01), EndDate = new DateTime(2019, 06, 01), Name = "Custom Controls" });
            lstProjects.Add(new Project() { ID = new Guid("72122d19-64cf-4938-a253-e9d36573bc00"), StartDate = new DateTime(2018, 11, 01), EndDate = new DateTime(2019, 06, 01), Name = "User Acceptence Test" });

            lstProjects.Add(new Project() { ID = new Guid("ccb18c40-49f1-4567-ac24-bce265567ffe"), StartDate = new DateTime(2018, 12, 01), EndDate = new DateTime(2019, 12, 01), Name = "Change" });
            lstProjects.Add(new Project() { ID = new Guid("869a8845-a40d-4294-9bf3-91711d04ebe9"), StartDate = new DateTime(2018, 12, 01), EndDate = new DateTime(2019, 12, 01), Name = "User Acceptence Test" });
            lstProjects.Add(new Project() { ID = new Guid("850f05a3-dfdf-4d9f-b231-e7f3191b018e"), StartDate = new DateTime(2018, 12, 01), EndDate = new DateTime(2019, 06, 01), Name = "Developer Support" });
            lstProjects.Add(new Project() { ID = new Guid("b1dd24d4-b163-484e-b6a3-034078b39154"), StartDate = new DateTime(2018, 12, 01), EndDate = new DateTime(2019, 06, 01), Name = "Developer Support" });

            return lstProjects;
        }

        private static List<Contract> CreateCustomerContracts()
        {
            List<Contract> lstContract = new List<Contract>();
            lstContract.Add(new Contract() { ID = new Guid("f023614b-ff57-4f5b-8655-79dbfdc0b495"), Description = "Office Deployment", Projects = new List<Guid>() { new Guid("0d8d1d53-67a8-42a4-874f-740b7b403ed0"), new Guid("f1bfccf7-f0b1-45e5-88cc-0fb4f8862ff5"), new Guid("3dead4b4-a935-4620-9ec8-ade32cf59caa"), new Guid("c2bcc33a-ab7f-45d1-b33d-57fcdf385fc8"), new Guid("96ac7f07-c10b-4d4b-88af-9abdf1360ef4") } });
            lstContract.Add(new Contract() { ID = new Guid("c876d03b-1425-40f3-9131-b00309d0553d"), Description = "Office 365 Migration", Projects = new List<Guid>() { new Guid("1835d97c-51c4-4823-81da-4a696a151dad"), new Guid("05255478-5976-479d-aaba-7757802bc0cc"), new Guid("361164cb-a45f-4c8b-9479-054201e60cc1") } });
            lstContract.Add(new Contract() { ID = new Guid("22ad7832-ef3a-417a-bd27-57c4c00f5e1b"), Description = "SharePoint Development", Projects = new List<Guid>() { new Guid("9b4a15bf-6d15-4eca-a29e-f923e7a843cf"), new Guid("087ee121-1f29-4fc7-a6cc-5302e6eaa5ec"), new Guid("ccb18c40-49f1-4567-ac24-bce265567ffe") } });
            lstContract.Add(new Contract() { ID = new Guid("dbd5dabb-d263-4556-a2e8-57fc3eda657d"), Description = "Industry 4.0", Projects = new List<Guid>() { new Guid("192f6683-eec7-41fa-869a-0aa5239d3bda"), new Guid("155e43d4-86b6-4e6d-9f94-c26f97eeb62f") } });
            lstContract.Add(new Contract() { ID = new Guid("b2bd8d6d-181f-4eb2-8700-d8922a5ab6ef"), Description = "Microsoft 365", Projects = new List<Guid>() { new Guid("32a23acd-2abd-4bb9-b391-23f74a714557") } });
            lstContract.Add(new Contract() { ID = new Guid("40768a14-971e-4710-a434-49e6e047f96f"), Description = "Windows 10 Migration", Projects = new List<Guid>() { new Guid("0661f809-35a6-4bc5-87e7-27b1866c2a74"), new Guid("850f05a3-dfdf-4d9f-b231-e7f3191b018e") } });
            lstContract.Add(new Contract() { ID = new Guid("78f949c8-d2c4-4bdb-93a5-f0e3b28cf424"), Description = "IOT", Projects = new List<Guid>() { new Guid("480a1213-e846-4246-9721-d2eb77808ffc"), new Guid("66a5a348-5deb-4616-9c0a-10d062d6b54c") } });
            lstContract.Add(new Contract() { ID = new Guid("90d55de4-b350-4462-a133-90dc8c157564"), Description = "Office integration", Projects = new List<Guid>() { new Guid("db52b28c-d8f4-42a3-b082-108408134891"), new Guid("3b1f3899-471d-4cf7-8e32-8b94ed61ea93") } });
            lstContract.Add(new Contract() { ID = new Guid("5034f738-e708-4225-a4d5-996b2aef8724"), Description = "Network Assessment", Projects = new List<Guid>() { new Guid("55c5628c-adbf-45a4-9d0c-3198abe5614b") } });
            lstContract.Add(new Contract() { ID = new Guid("1509a866-3220-400c-a436-5462d15f46c2"), Description = "Network Assessment", Projects = new List<Guid>() { new Guid("739105de-b404-41ec-8da3-546790ee8b43") } });
            lstContract.Add(new Contract() { ID = new Guid("5f24b2f1-3c42-4be3-a717-b34b44af8041"), Description = "Design Workshop", Projects = new List<Guid>() { new Guid("1274ef80-04b2-4905-9776-99df5af0846b") } });
            lstContract.Add(new Contract() { ID = new Guid("5074b63c-ae78-4833-be46-d15e889d199b"), Description = "Azure Integration", Projects = new List<Guid>() { new Guid("6d696082-1f4a-4128-b440-2ee4c62182a6"), new Guid("40395acd-819f-4b4c-b684-ad74db85b3ca") } });
            lstContract.Add(new Contract() { ID = new Guid("be5bf00e-3645-4994-995b-eb3182cdc72e"), Description = "AI Integration", Projects = new List<Guid>() { new Guid("7bd2cd8d-db9d-479c-bb2c-d2550b26ab81"), new Guid("a32eb050-5b01-4cd6-a55b-282d718c8cba"), new Guid("5bf45c74-da78-4d47-b9a5-ee7193f36587"), new Guid("c89c1b8e-9528-48c1-96eb-b94f38ab175b") } });
            lstContract.Add(new Contract() { ID = new Guid("0e327598-7726-4b2f-9006-e2b8db4a1fed"), Description = "Cognitive Services", Projects = new List<Guid>() { new Guid("9db8404e-80f1-4eb2-8dfd-0d3f1347984a"), new Guid("27a5e626-2502-4651-b798-cc1d7c50f063") } });
            lstContract.Add(new Contract() { ID = new Guid("889a9898-8f4e-4042-b646-a2acea9a9d1d"), Description = "Fleetcontrol", Projects = new List<Guid>() { new Guid("b79c22e8-beb2-4a21-acbc-efa373ee9f41"), new Guid("6debfcc0-52dd-4077-8c88-5e791f32b45d"), new Guid("997c08ab-5e30-40ba-89f0-f68f1043acb5"), new Guid("869a8845-a40d-4294-9bf3-91711d04ebe9"), new Guid("b1dd24d4-b163-484e-b6a3-034078b39154") } });
            lstContract.Add(new Contract() { ID = new Guid("2e6696d7-64f9-4364-8fff-d74ff0a416bf"), Description = "Predictive Maintenance", Projects = new List<Guid>() { new Guid("158f2eec-759a-4c95-8950-98ec1e93b8d7"), new Guid("bd4f95c7-eca5-4e31-8753-db18a69d640a"), new Guid("3cefd722-ffef-473d-a5a7-3e63809e9378") } });
            lstContract.Add(new Contract() { ID = new Guid("e20c28a5-c4c9-428f-a7d1-de2cb1c45f25"), Description = "Anomaly Detection", Projects = new List<Guid>() { new Guid("d497bb5b-f0e0-4678-a51e-97624521b659"), new Guid("d501350a-32eb-4c77-8ec9-335f1e9f7a7a"), new Guid("6ba436ef-c1b3-4604-9654-34a03a257ba0") } });
            lstContract.Add(new Contract() { ID = new Guid("606a4dde-5113-4a24-af1d-14ad579cee11"), Description = "Enterprise Power BI", Projects = new List<Guid>() { new Guid("64c39039-3796-4994-9651-ee704201a1db"), new Guid("118ca642-e9f3-43e9-9dda-5a602419cf53"), new Guid("6ea2c510-2f99-40a6-a8b6-9f2d8ea13b6c") } });
            lstContract.Add(new Contract() { ID = new Guid("141bf1de-d7d0-48dc-9b03-5e1308c31f4e"), Description = "Machine Learning Workshop", Projects = new List<Guid>() { new Guid("65f1d0c2-0950-4134-90b2-370d846afc7b"), new Guid("72122d19-64cf-4938-a253-e9d36573bc00") } });

            return lstContract;
        }

        private static List<TimeBooking> CreateBookings()
        {
            List<TimeBooking> lstBookings = new List<TimeBooking>();
            lstBookings.Add(new TimeBooking() { ID = new Guid("5f24b2f1-3c42-4be3-a717-b34b44af8041"), Created = DateTime.Now, Date = DateTime.Now, Description = "DFG Addin Development", ForecastHours = 4, Hours = 4, Long = double.Parse("6,981647"), Lat = double.Parse("51,021448") });
            lstBookings.Add(new TimeBooking() { ID = new Guid("889a9898-8f4e-4042-b646-a2acea9a9d1d"), Created = DateTime.Now, Date = DateTime.Now, Description = "Bosch Learning Portal", ForecastHours = 4, Hours = 4, Long = double.Parse("9,641250"), Lat = double.Parse("52,418125") });

            return lstBookings;
        }

        private static List<Customer> CreateCustomer()
        {
            List<Customer> lstCustomer = new List<Customer>();

            lstCustomer.Add(new Customer() { ID = new Guid("ccd22759-3dd0-4097-83dd-a50f1791ddf4"), Name = "adidas", Contracts = new List<Guid>() { new Guid("f023614b-ff57-4f5b-8655-79dbfdc0b495"), new Guid("c876d03b-1425-40f3-9131-b00309d0553d"), new Guid("141bf1de-d7d0-48dc-9b03-5e1308c31f4e") }, Domain = "adidas.de", Locations = new List<Guid>() { new Guid("a813c93b-c356-4742-9321-eae8d3dedb1a") } });
            lstCustomer.Add(new Customer() { ID = new Guid("646b7b58-088e-4485-9ebd-0f194ce5a96e"), Name = "Allianz", Contracts = new List<Guid>() { new Guid("22ad7832-ef3a-417a-bd27-57c4c00f5e1b"), new Guid("dbd5dabb-d263-4556-a2e8-57fc3eda657d") }, Domain = "allianz.de", Locations = new List<Guid>() { new Guid("23f3578d-4331-4455-b9bc-da04d0a5dc1c") } });
            lstCustomer.Add(new Customer() { ID = new Guid("e4fbac60-afb4-4715-bdb8-3f09d1a19976"), Name = "BASF", Contracts = new List<Guid>() { new Guid("b2bd8d6d-181f-4eb2-8700-d8922a5ab6ef"), new Guid("40768a14-971e-4710-a434-49e6e047f96f"), new Guid("606a4dde-5113-4a24-af1d-14ad579cee11") }, Domain = "basf.de", Locations = new List<Guid>() { new Guid("46948eb7-053a-4f55-bb4c-c5daaedce095") } });
            lstCustomer.Add(new Customer() { ID = new Guid("3b57c35e-1917-443b-8bbc-9b9d659a3d6b"), Name = "Bayer", Contracts = new List<Guid>() { new Guid("78f949c8-d2c4-4bdb-93a5-f0e3b28cf424"), new Guid("90d55de4-b350-4462-a133-90dc8c157564") }, Domain = "bayer.de", Locations = new List<Guid>() { new Guid("174c995d-c18b-4d1c-b012-847a0a2bd644") } });
            lstCustomer.Add(new Customer() { ID = new Guid("f4ab419d-c400-4d7d-8f4a-741333f52f0a"), Name = "Beiersdorf", Contracts = new List<Guid>() { new Guid("5034f738-e708-4225-a4d5-996b2aef8724"), new Guid("1509a866-3220-400c-a436-5462d15f46c2"), new Guid("e20c28a5-c4c9-428f-a7d1-de2cb1c45f25") }, Domain = "beiersdorf.de", Locations = new List<Guid>() { new Guid("67001834-5180-4995-8b99-f90481893221") } });
            lstCustomer.Add(new Customer() { ID = new Guid("10817bd3-0c64-4b32-8463-fc104f7f1666"), Name = "BMW", Contracts = new List<Guid>() { new Guid("5f24b2f1-3c42-4be3-a717-b34b44af8041"), new Guid("5074b63c-ae78-4833-be46-d15e889d199b") }, Domain = "bmw.de", Locations = new List<Guid>() { new Guid("af27b8e6-04d8-4255-88a6-90b7d6675a41") } });
            lstCustomer.Add(new Customer() { ID = new Guid("646aaea5-af87-4f04-bc25-922c5c73a404"), Name = "Commerzbank", Contracts = new List<Guid>() { new Guid("be5bf00e-3645-4994-995b-eb3182cdc72e"), new Guid("0e327598-7726-4b2f-9006-e2b8db4a1fed") }, Domain = "commerzbank.de", Locations = new List<Guid>() { new Guid("ca74cfb2-357f-4a6b-9bbd-6affc0eaf199") } });
            lstCustomer.Add(new Customer() { ID = new Guid("9be5d219-0630-47bf-8bc7-751c50f35b1f"), Name = "Continental", Contracts = new List<Guid>() { new Guid("889a9898-8f4e-4042-b646-a2acea9a9d1d"), new Guid("2e6696d7-64f9-4364-8fff-d74ff0a416bf") }, Domain = "continental.de", Locations = new List<Guid>() { new Guid("df6482de-b7dd-46fc-8513-69ef28b96d29") } });
            //lstCustomer.Add(new Customer() { ID = new Guid("0113c8f3-cd56-4d60-9e7b-4a8f791d7472"), Name = "Covestro", Contracts = new List<Guid>(), Domain = "covestro.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("ab786e5e-6756-4a9c-8c67-687b7042cda1"), Name = "Daimler", Contracts = new List<Guid>(), Domain = "daimler.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("537e48b4-8d0a-4614-83d5-31ebfc1d42c4"), Name = "Deutsche Bank", Contracts = new List<Guid>(), Domain = "deutschebank.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("e05559e0-43a4-4031-948c-ed1f7ca3bc67"), Name = "Deutsche Börse", Contracts = new List<Guid>(), Domain = "deutscheboerse.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("091b5efa-564e-4588-83ac-3a47aeaa11e7"), Name = "Deutsche Post", Contracts = new List<Guid>(), Domain = "deutschepost.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("c1ccc615-d92f-4d9d-b605-c1607af37e76"), Name = "Deutsche Telekom", Contracts = new List<Guid>(), Domain = "telekom.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("f1360579-3d15-47c0-93c8-e18f8cb074f3"), Name = "E.ON", Contracts = new List<Guid>(), Domain = "eon.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("8c9bb236-48b5-482a-91d7-81c789870837"), Name = "Fresenius", Contracts = new List<Guid>(), Domain = "fresenius.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("2b76520a-29f2-45eb-b10f-35a6174678be"), Name = "HeidelbergCement", Contracts = new List<Guid>(), Domain = "heidelbergcement.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("dc4c9cdf-bfc8-4cd9-9731-773567380e8c"), Name = "Henkel vz.", Contracts = new List<Guid>(), Domain = "henkel.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("78baa268-8b0a-4d6d-90f7-1f2f6bbe2cd3"), Name = "Infineon", Contracts = new List<Guid>(), Domain = "infineon.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("9dcf53a6-8465-4460-9c59-cbdbef8f533c"), Name = "Linde", Contracts = new List<Guid>(), Domain = "linde.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("3063f044-7959-4731-876c-e4caa38f9984"), Name = "Lufthansa", Contracts = new List<Guid>(), Domain = "lufthansa.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("c9d51a45-6d8e-400e-96f2-9823eda9e10e"), Name = "Merck", Contracts = new List<Guid>(), Domain = "merck.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("f348fd02-ca70-4aa0-9ae7-acffac4d0f18"), Name = "RWE", Contracts = new List<Guid>(), Domain = "rwe.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("d7fb9105-a327-430b-9a3d-e109a2b87ca9"), Name = "SAP", Contracts = new List<Guid>(), Domain = "sap.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("ef505d82-4603-4313-bb05-4867e4efc3c5"), Name = "Siemens", Contracts = new List<Guid>(), Domain = "siemens.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("6b208718-8bf5-444c-be3b-5f729aa999f5"), Name = "thyssenkrupp", Contracts = new List<Guid>(), Domain = "thyssenkrupp.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("0ed48e67-6cfd-4f90-80e3-7fefaffa27c4"), Name = "Volkswagen (VW) vz.", Contracts = new List<Guid>(), Domain = "vw.de", Locations = new List<Guid>() });
            //lstCustomer.Add(new Customer() { ID = new Guid("187dede5-c82b-4a87-9946-0e05fa8eca92"), Name = "Vonovia", Contracts = new List<Guid>(), Domain = "vonovia.de", Locations = new List<Guid>() });

            return lstCustomer;
        }

        private static List<Location> CreateCustomerLocations()
        {
            List<Location> lstLocations = new List<Location>();

            //Adidas 49,564815, 10,868900
            lstLocations.Add(new Location() { ID = new Guid("a813c93b-c356-4742-9321-eae8d3dedb1a"), City = "Herzogenaurach", Country = "Germany", Lon = double.Parse("10,868900"), Lat = double.Parse("49,564815") });

            //Allianz
            lstLocations.Add(new Location() { ID = new Guid("23f3578d-4331-4455-b9bc-da04d0a5dc1c"), City = "München", Country = "Germany", Lon = double.Parse("11,414702"), Lat = double.Parse("48,079645") });

            //BASF
            lstLocations.Add(new Location() { ID = new Guid("46948eb7-053a-4f55-bb4c-c5daaedce095"), City = "Ludwigshafen am Rhein", Country = "Germany", Lon = double.Parse("8,438535"), Lat = double.Parse("49,475220") });

            //Bayer
            lstLocations.Add(new Location() { ID = new Guid("174c995d-c18b-4d1c-b012-847a0a2bd644"), City = "Monheim", Country = "Germany", Lon = double.Parse("6,981647"), Lat = double.Parse("51,021448") });

            //Beiersdorf
            lstLocations.Add(new Location() { ID = new Guid("67001834-5180-4995-8b99-f90481893221"), City = "Hamburg", Country = "Germany", Lon = double.Parse("9,992470"), Lat = double.Parse("53,553341") });

            //BMW
            lstLocations.Add(new Location() { ID = new Guid("af27b8e6-04d8-4255-88a6-90b7d6675a41"), City = "München", Country = "Germany", Lon = double.Parse("11,414702"), Lat = double.Parse("48,079645") });

            //Commerzbank
            lstLocations.Add(new Location() { ID = new Guid("ca74cfb2-357f-4a6b-9bbd-6affc0eaf199"), City = "Frankfurt", Country = "Germany", Lon = double.Parse("8,681681"), Lat = double.Parse("50,111632") });

            //Continental
            lstLocations.Add(new Location() { ID = new Guid("df6482de-b7dd-46fc-8513-69ef28b96d29"), City = "Hannover", Country = "Germany", Lon = double.Parse("9,641250"), Lat = double.Parse("52,418125") });
            //lstLocations.Add(new Location() { ID = new Guid("ea6f83ba-11e8-471d-92e0-3ab43cf56671"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("c2a29f29-5cfc-4ce8-9270-cb5f82f65176"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("c2ee5661-cff0-443c-8927-464d58466ff1"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("93930233-abd5-49d7-b932-516202a789cb"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("39c0f34b-1852-4571-a32e-5067a929d136"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("60e39f47-4ea0-4711-9345-838791d4350c"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("1bc0a26d-95a2-48ec-b76c-d07a925e98d0"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("d3a8a43f-8ffc-4ec1-b186-3872499566db"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("b2737cf6-242c-4144-8eaf-31544cf9395c"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("d05d5710-d38e-4a3a-b022-b344d86e4f61"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("1bdc52ff-2805-4860-9f3a-ffbe3f38a3c6"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("9de16b99-d1a5-48c0-8cc8-d7c984349da8"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("61c4fecb-9597-4705-b5fc-c82402530b5e"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("edab1ac1-d152-497a-bbff-cf65fa051f3c"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("b5a1de5b-3482-4f1c-914d-1b9cb7ab1589"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("ba54605c-b137-4ed5-981e-a28467ff651e"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("8321867c-b433-4d55-bb8c-79c976ad60ce"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("146b76d5-476c-463d-a962-0f8d13251ad5"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("6ca90532-9e93-40d3-b01e-76d565682897"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("572d4a4f-2671-484b-84ba-1641337d7bbe"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("08449982-09e9-4b7a-8b0a-ae7ff0081234"), City = "", Country = "Germany" });
            //lstLocations.Add(new Location() { ID = new Guid("fe3cd06f-d2d5-4a5c-a48d-88aeaf43bc03"), City = "", Country = "Germany" });

            return lstLocations;
        }
    }
}
