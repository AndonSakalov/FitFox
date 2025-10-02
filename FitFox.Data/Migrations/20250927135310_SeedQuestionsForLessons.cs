using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuestionsForLessons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerId", "IsDeleted", "LessonId", "Text" },
                values: new object[,]
                {
                    { new Guid("018a8f7d-e12b-49d5-8718-889aa668cafb"), null, false, new Guid("7e065ddc-a469-4bbe-b205-113c3d96f4c5"), "Why is recovery important after training?" },
                    { new Guid("04ecf251-b526-4445-a6f6-a6c7dfdd586a"), null, false, new Guid("81476c31-4e91-41d5-b37e-422e97b5882e"), "What is a compound movement?" },
                    { new Guid("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f"), null, false, new Guid("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"), "Resistance training can help prevent which age-related condition?" },
                    { new Guid("0ef6cf36-8764-4924-9b01-5fcc247c96aa"), null, false, new Guid("0491fb6d-5264-4beb-88e6-a247489c4825"), "Which of the following are considered micronutrients?" },
                    { new Guid("1020c72c-9f20-4b04-8523-e2a9dc643ed2"), null, false, new Guid("0491fb6d-5264-4beb-88e6-a247489c4825"), "A deficiency in Vitamin C can lead to which condition?" },
                    { new Guid("196f6df9-6234-499b-9309-c6b0cd29e349"), null, false, new Guid("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"), "Which of the following is a mental health benefit of resistance training?" },
                    { new Guid("1e3c972d-3549-4d00-8ca5-88ac510abe63"), null, false, new Guid("81476c31-4e91-41d5-b37e-422e97b5882e"), "Why are isolation exercises useful?" },
                    { new Guid("27365168-3b26-4638-927a-0a0d32108cd7"), null, false, new Guid("7e065ddc-a469-4bbe-b205-113c3d96f4c5"), "Which strategy helps reduce delayed onset muscle soreness (DOMS)?" },
                    { new Guid("2ca88517-a1ad-4bc9-9283-0e4100d60dcd"), null, false, new Guid("81476c31-4e91-41d5-b37e-422e97b5882e"), "Which is the best approach for building a balanced physique?" },
                    { new Guid("2cd2b95d-63c0-4c7f-9485-3df385a91476"), null, false, new Guid("98479667-cd5b-4953-a442-de348acda994"), "Which electrolyte is often lost in large amounts through sweat?" },
                    { new Guid("34c91eb1-1e3b-4f7b-bf02-8b9f34653023"), null, false, new Guid("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e"), "Which protein source is faster digesting and ideal post-workout?" },
                    { new Guid("39d43280-d51f-4a8e-921f-97b6f4b2873e"), null, false, new Guid("8e10a739-c7a9-4c9e-887c-b2599be94f3a"), "Which is a common beginner-friendly training split?" },
                    { new Guid("3b1a72e5-e73e-4e8d-833e-b92a61eb2664"), null, false, new Guid("98479667-cd5b-4953-a442-de348acda994"), "How many liters of water are generally recommended per day for an average adult?" },
                    { new Guid("3bbce0fb-8e12-4a03-837d-9ac269f282ff"), null, false, new Guid("98479667-cd5b-4953-a442-de348acda994"), "Magnesium helps with all of the following EXCEPT:" },
                    { new Guid("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea"), null, false, new Guid("8e10a739-c7a9-4c9e-887c-b2599be94f3a"), "An advanced lifter looking to focus on lagging muscle groups might benefit most from:" },
                    { new Guid("3da3629a-ace4-45f2-900b-6c134ba6231b"), null, false, new Guid("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"), "What is one of the main benefits of resistance training?" },
                    { new Guid("4420dd55-0f57-439b-bc4b-47623fe05e5c"), null, false, new Guid("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"), "Resistance training can help with fat loss primarily by:" },
                    { new Guid("4c550c86-a27f-480d-8a34-26a5d94d7bb3"), null, false, new Guid("98479667-cd5b-4953-a442-de348acda994"), "A common sign of dehydration is:" },
                    { new Guid("4fbd5ee9-c603-4530-a325-0b8c94d87e52"), null, false, new Guid("0491fb6d-5264-4beb-88e6-a247489c4825"), "Which vitamin is essential for calcium absorption and bone health?" },
                    { new Guid("562c6f2d-4216-4f46-b74b-a764a7ad5418"), null, false, new Guid("81476c31-4e91-41d5-b37e-422e97b5882e"), "Which of the following is an isolation exercise?" },
                    { new Guid("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb"), null, false, new Guid("8e10a739-c7a9-4c9e-887c-b2599be94f3a"), "Which training split is best for maximizing recovery while still training frequently?" },
                    { new Guid("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90"), null, false, new Guid("98479667-cd5b-4953-a442-de348acda994"), "Which electrolyte helps regulate heart rhythm and fluid balance?" },
                    { new Guid("5f83b77f-09eb-43ab-aac6-1ba1a74a8225"), null, false, new Guid("7e065ddc-a469-4bbe-b205-113c3d96f4c5"), "What is a deload week?" },
                    { new Guid("6632e20e-4ff2-4342-8af2-698acaf6e495"), null, false, new Guid("7e065ddc-a469-4bbe-b205-113c3d96f4c5"), "How many hours of sleep are generally recommended for optimal recovery?" },
                    { new Guid("6aea4f8b-3785-4027-8532-6592c9436898"), null, false, new Guid("0491fb6d-5264-4beb-88e6-a247489c4825"), "Zinc plays an important role in:" },
                    { new Guid("6c611141-34e9-4ae5-892c-27106d39782d"), null, false, new Guid("7e065ddc-a469-4bbe-b205-113c3d96f4c5"), "Which nutrient is particularly important for muscle repair?" },
                    { new Guid("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062"), null, false, new Guid("7e065ddc-a469-4bbe-b205-113c3d96f4c5"), "Which of the following can negatively affect recovery?" },
                    { new Guid("706cec35-8678-40a3-bf08-3f4a001765e5"), null, false, new Guid("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"), "Long-term resistance training can reduce the risk of:" },
                    { new Guid("725ac1b4-5362-484a-964a-4a1bc95a2aab"), null, false, new Guid("97300d33-6cc5-48ba-b495-ff21d5b16419"), "What is the typical protein intake per kg of body weight for a person trying to build muscle?" },
                    { new Guid("734b09f7-245b-43cf-bf1a-87a2ead54981"), null, false, new Guid("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"), "Resistance training improves bone health by:" },
                    { new Guid("7a37747e-9f9c-4d6d-a25a-10ee17d64a09"), null, false, new Guid("8e10a739-c7a9-4c9e-887c-b2599be94f3a"), "What is the main advantage of a full-body workout split?" },
                    { new Guid("8b071bdd-25b1-4ab2-9c64-32e44e2eb889"), null, false, new Guid("cde73646-a8fb-4131-9308-8269ea662c54"), "Which muscle is primarily targeted by the overhead shoulder press?" },
                    { new Guid("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff"), null, false, new Guid("cde73646-a8fb-4131-9308-8269ea662c54"), "Which primary muscle does the bench press target?" },
                    { new Guid("905e3202-c416-470b-8e11-ce66a9f7a534"), null, false, new Guid("81476c31-4e91-41d5-b37e-422e97b5882e"), "Why are compound lifts often performed at the beginning of a workout?" },
                    { new Guid("99e612f3-3e52-4616-8ea1-19d620463779"), null, false, new Guid("0491fb6d-5264-4beb-88e6-a247489c4825"), "Which vitamin is primarily produced by the body when exposed to sunlight?" },
                    { new Guid("a9fced86-bd78-4901-b983-f05a2ad96bcd"), null, false, new Guid("81476c31-4e91-41d5-b37e-422e97b5882e"), "What is the main benefit of compound movements?" },
                    { new Guid("ab0fda0c-dca4-4b12-a690-8e1b311ee5de"), null, false, new Guid("97300d33-6cc5-48ba-b495-ff21d5b16419"), "For a cutting diet, which macronutrient is often reduced first?" },
                    { new Guid("af7f8faf-0b47-43a7-bce0-2120af75c39c"), null, false, new Guid("0491fb6d-5264-4beb-88e6-a247489c4825"), "Which group of vitamins is fat-soluble?" },
                    { new Guid("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee"), null, false, new Guid("97300d33-6cc5-48ba-b495-ff21d5b16419"), "For someone on a low-carb diet, which macronutrient is usually increased to compensate for reduced carbs?" },
                    { new Guid("b6d72991-5934-4d11-8c64-2144493e4fc6"), null, false, new Guid("cde73646-a8fb-4131-9308-8269ea662c54"), "Pull-ups primarily strengthen which muscle group?" },
                    { new Guid("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b"), null, false, new Guid("cde73646-a8fb-4131-9308-8269ea662c54"), "Lunges are most effective for strengthening:" },
                    { new Guid("b850b9da-babb-465e-96b4-99639f04711e"), null, false, new Guid("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e"), "When is protein consumption most effective for muscle recovery?" },
                    { new Guid("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e"), null, false, new Guid("cde73646-a8fb-4131-9308-8269ea662c54"), "Which exercise is best for isolating the biceps?" },
                    { new Guid("c29ae0bc-eb61-45c1-be09-2e24ca66862b"), null, false, new Guid("98479667-cd5b-4953-a442-de348acda994"), "What is the main function of water in the body?" },
                    { new Guid("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4"), null, false, new Guid("97300d33-6cc5-48ba-b495-ff21d5b16419"), "Which macronutrient is usually prioritized for muscle gain?" },
                    { new Guid("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794"), null, false, new Guid("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e"), "Casein protein is best consumed:" },
                    { new Guid("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4"), null, false, new Guid("b1adc18d-8c55-4a74-8bf6-a9a2943fd9e7"), "How does resistance training affect metabolism?" },
                    { new Guid("d3207231-b15e-428f-b6e7-ab53471202af"), null, false, new Guid("7e065ddc-a469-4bbe-b205-113c3d96f4c5"), "Which of the following is a type of active recovery?" },
                    { new Guid("d76f8572-c76d-4ea6-96e2-88f94b2ef5db"), null, false, new Guid("98479667-cd5b-4953-a442-de348acda994"), "Which electrolyte is most important for muscle contraction and nerve function?" },
                    { new Guid("da4b1734-79df-4b91-a69f-7c52b4b7553a"), null, false, new Guid("cde73646-a8fb-4131-9308-8269ea662c54"), "Deadlifts primarily target:" },
                    { new Guid("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e"), null, false, new Guid("8e10a739-c7a9-4c9e-887c-b2599be94f3a"), "What is a “training split” in fitness?" },
                    { new Guid("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5"), null, false, new Guid("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e"), "Combining different plant proteins can help:" },
                    { new Guid("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72"), null, false, new Guid("8e10a739-c7a9-4c9e-887c-b2599be94f3a"), "How many times per week should a beginner ideally train each muscle group?" },
                    { new Guid("e74d6670-97b6-42c9-8464-881dbb6bfa9d"), null, false, new Guid("77c74f8c-a3ef-4cb8-8a2c-b71ca6ecd33e"), "Which protein source is considered “complete”, containing all essential amino acids?" },
                    { new Guid("ed946370-816b-4175-bfee-cc24d3d3c971"), null, false, new Guid("81476c31-4e91-41d5-b37e-422e97b5882e"), "Which of the following is an example of a compound movement?" },
                    { new Guid("f35e77c4-447c-46f3-893e-62110c2ff969"), null, false, new Guid("8e10a739-c7a9-4c9e-887c-b2599be94f3a"), "Why is rest important between training sessions for the same muscle group?" },
                    { new Guid("f68f4855-4f08-4e5e-9480-497f2e7f70c5"), null, false, new Guid("cde73646-a8fb-4131-9308-8269ea662c54"), "The squat primarily works which muscle group?" },
                    { new Guid("fc987683-272e-4874-9ec0-adbd1d4d43f0"), null, false, new Guid("0491fb6d-5264-4beb-88e6-a247489c4825"), "Which mineral is important for oxygen transport in the blood?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("018a8f7d-e12b-49d5-8718-889aa668cafb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("04ecf251-b526-4445-a6f6-a6c7dfdd586a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0ef6cf36-8764-4924-9b01-5fcc247c96aa"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1020c72c-9f20-4b04-8523-e2a9dc643ed2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("196f6df9-6234-499b-9309-c6b0cd29e349"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1e3c972d-3549-4d00-8ca5-88ac510abe63"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("27365168-3b26-4638-927a-0a0d32108cd7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2ca88517-a1ad-4bc9-9283-0e4100d60dcd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2cd2b95d-63c0-4c7f-9485-3df385a91476"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("34c91eb1-1e3b-4f7b-bf02-8b9f34653023"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("39d43280-d51f-4a8e-921f-97b6f4b2873e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3b1a72e5-e73e-4e8d-833e-b92a61eb2664"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3bbce0fb-8e12-4a03-837d-9ac269f282ff"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3da3629a-ace4-45f2-900b-6c134ba6231b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4420dd55-0f57-439b-bc4b-47623fe05e5c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4c550c86-a27f-480d-8a34-26a5d94d7bb3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4fbd5ee9-c603-4530-a325-0b8c94d87e52"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("562c6f2d-4216-4f46-b74b-a764a7ad5418"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5f83b77f-09eb-43ab-aac6-1ba1a74a8225"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6632e20e-4ff2-4342-8af2-698acaf6e495"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6aea4f8b-3785-4027-8532-6592c9436898"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6c611141-34e9-4ae5-892c-27106d39782d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("706cec35-8678-40a3-bf08-3f4a001765e5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("725ac1b4-5362-484a-964a-4a1bc95a2aab"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("734b09f7-245b-43cf-bf1a-87a2ead54981"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7a37747e-9f9c-4d6d-a25a-10ee17d64a09"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8b071bdd-25b1-4ab2-9c64-32e44e2eb889"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("905e3202-c416-470b-8e11-ce66a9f7a534"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("99e612f3-3e52-4616-8ea1-19d620463779"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a9fced86-bd78-4901-b983-f05a2ad96bcd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ab0fda0c-dca4-4b12-a690-8e1b311ee5de"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("af7f8faf-0b47-43a7-bce0-2120af75c39c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b6d72991-5934-4d11-8c64-2144493e4fc6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b850b9da-babb-465e-96b4-99639f04711e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c29ae0bc-eb61-45c1-be09-2e24ca66862b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d3207231-b15e-428f-b6e7-ab53471202af"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d76f8572-c76d-4ea6-96e2-88f94b2ef5db"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("da4b1734-79df-4b91-a69f-7c52b4b7553a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e74d6670-97b6-42c9-8464-881dbb6bfa9d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ed946370-816b-4175-bfee-cc24d3d3c971"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f35e77c4-447c-46f3-893e-62110c2ff969"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f68f4855-4f08-4e5e-9480-497f2e7f70c5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fc987683-272e-4874-9ec0-adbd1d4d43f0"));
        }
    }
}
