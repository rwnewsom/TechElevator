namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int raccoonsPlaying = 3;
            int racoonsLeaving = 2;
            int racoonsLeft = raccoonsPlaying - racoonsLeaving;

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int excessFlowers = flowers - bees;

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lonelyPigeon = 1;
            int newPigeon = 1;
            int breadcrumbEatingPigeons = lonelyPigeon + newPigeon;

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int sittingOwls = 3;
            int joiningOwls = 2;
            int totalOwls = sittingOwls + joiningOwls;

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int workingBeavers = 2;
            int slackerSwimmingBeaver = 1;
            int angryBeaver = workingBeavers - slackerSwimmingBeaver;

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int originalToucans = 2;
            int toucanCrasher = 1;
            int awkwardToucanDate = originalToucans + toucanCrasher;

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int numberOfSquirrels = 4;
            int availableNuts = 2;
            int nutlessSquirrels = numberOfSquirrels - availableNuts;

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarters = 0.25M;
            decimal dimes = 0.1M;
            decimal nickels = 0.1M;
            decimal totalMoneyInPennies = quarters + dimes + nickels;

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int mrsBriersClassMuffins = 18;
            int mrsMacAdamsClassMuffins = 20;
            int mrsFlannerysClassMuffins = 17;
            int totalFirstGradeClassMuffins = mrsBriersClassMuffins + mrsMacAdamsClassMuffins + mrsFlannerysClassMuffins;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyoPrice = 0.24M;
            decimal whistlePrice = 0.14M;
            decimal totalPrice = yoyoPrice + whistlePrice;

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */

            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalMarshmallowsUsed = largeMarshmallows + miniMarshmallows;

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouseSnowDepthInInches = 29;
            int brecknockElementarySnowDepthInInches = 17;
            int snowDelta = hiltHouseSnowDepthInInches - brecknockElementarySnowDepthInInches;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            decimal mrsHiltInitialCash = 10M;
            decimal toyTruckExpense = 3M;
            decimal pencilCaseExpense = 2M;
            decimal mrsHiltRemainingCash = mrsHiltInitialCash - (toyTruckExpense + pencilCaseExpense);

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int initialMarbles = 16;
            int lostMarbles = 7;
            int remainingMarbles = initialMarbles - lostMarbles;

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int availableSeashells = 19;
            int requiredSeashells = 25;
            int seaShellShortfall = requiredSeashells - availableSeashells;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int initialBookCount = 38;
            int addedBooks = 10;
            int newBookTotal = initialBookCount + addedBooks;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int legsPerBee = 6;
            int beeCount = 8;
            int beeLegTotal = legsPerBee * beeCount;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCreamConeCost = .99M;
            decimal iceCreamConeQty = 2M;
            decimal totalIceCreamCost = iceCreamConeCost * iceCreamConeQty;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rockRequirement = 125;
            int rocksAvailable = 64;
            int rockShortfall = rockRequirement - rocksAvailable;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltOriginalMarbles = 38;
            int hiltLostMarbles = 15;
            int hiltMarblesLeft = hiltOriginalMarbles - hiltLostMarbles;

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int concertTripDistance = 78;
            int milesDrivenSoFar = 32;
            int milesToGo = concertTripDistance - milesDrivenSoFar;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int saturdayMorningShovelTime = 90;
            int saturdayAfternoonShovelTime = 45;
            int totalMinutesShoveling = saturdayAfternoonShovelTime + saturdayMorningShovelTime;

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            decimal hotDogCost = 0.5M;
            decimal hotDogQty = 6.0M;
            decimal hotDogExpense = hotDogCost * hotDogQty;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            decimal mrsHiltPencilFund = 0.5M;
            decimal pencilCost = .07M;
            int pencilsAffordable = ((int)(mrsHiltPencilFund / pencilCost));

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterflies - orangeButterflies;

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal cashTendered = 1M;
            decimal candyCost = 0.54M;
            decimal changeDue = cashTendered - candyCost;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int backyardTrees = 13;
            int treesPlanted = 12;
            int newTreeTotal = backyardTrees + treesPlanted;

            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int hoursInADay = 24;
            int daysUntilGranny = 2;
            int hoursUntilGranny = hoursInADay * daysUntilGranny;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int kimsCousinCount = 4;
            int gumPerCousin = 5;
            int totalCousinGum = kimsCousinCount * gumPerCousin;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal initialDanBalance = 3.00M;
            decimal candyBarExpense = 1.00M;
            decimal danMoneyLeft = initialDanBalance - candyBarExpense;

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatsOnLake = 5;
            int peoplePerBoat = 3;
            int totalBoatPeople = boatsOnLake * peoplePerBoat;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int initialLogos = 380;
            int lostLogos = 57; //lost logos are step hazards!
            int availableLogos = initialLogos - lostLogos;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthurMuffinQuota = 83;
            int arthurMuffinsBaked = 35;
            int arthurMuffinsShort = arthurMuffinQuota - arthurMuffinsBaked;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayonCount = 1400;
            int lucyCrayonCount = 290;
            int willyCrayonSurplus = willyCrayonCount - lucyCrayonCount;

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int pagesOfStickers = 22;
            int totalStickers = stickersPerPage * pagesOfStickers;


            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            decimal cupcakes = 96.0M;
            decimal children = 8.0M;
            decimal cupcakesPerChild = cupcakes / children;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            int gingerbreadCookies = 47;
            int tinyGlassJarCapacity = 6;
            int cookieRemainder = gingerbreadCookies % tinyGlassJarCapacity;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int totalCroissants = 59;
            int neighbors = 8;
            int spareCroissants = totalCroissants % neighbors;

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesPerTray = 12;
            int cookiesRequired = 276;
            int traysRequired = cookiesRequired / cookiesPerTray;

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalBiteSizedPretzels = 480;
            int biteSizedPretzelServingSize = 12;
            int biteSizedPretzelServings = totalBiteSizedPretzels / biteSizedPretzelServingSize;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakesBaked = 53;
            int lemonCupcakesLeft = 2;
            int lemonCupcakesPerBox = 3;
            int boxesGifted = (lemonCupcakesBaked - lemonCupcakesLeft) / lemonCupcakesPerBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int yuckyBreakfastCarrots = 74;
            int unfortunateFamily = 12;
            int uneatenCarrots = yuckyBreakfastCarrots % unfortunateFamily;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalTeddies = 98;
            int shelfTeddyCap = 7;
            int shelvesFilled = totalTeddies / shelfTeddyCap;

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int totalPics = 480;
            int albumCap = 20;
            int totalAlbumsNeeded = totalPics / albumCap;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalTradingCards = 94;
            int boxTradingCardCapacity = 8;
            int boxesFilled = totalTradingCards / boxTradingCardCapacity;
            int cardsInUnfilledBox = totalTradingCards % boxTradingCardCapacity;

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int repairedShelves = 10;
            int unshelvedBooks = 210;
            int booksPerShelf = unshelvedBooks / repairedShelves;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            double croissants = 17;
            double guests = 7;
            double croissantsServed = croissants / guests;

            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */

            double roomSize = (12 * 14);
            double projectSize = roomSize * 5;
            double billPaintRate = roomSize / 2.15;
            double jillPaintRate = roomSize / 1.90;
            double teamPaintRate = billPaintRate + jillPaintRate;
            double projectTime = projectSize / teamPaintRate;

            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */

            string firstName = "Grace";
            string lastName = "Hopper";
            string middleInitial = "B";
            string seperatorOne = ", ";
            string seperatorTwo = " ";
            string periodOne = ".";
            string fullName = lastName + seperatorOne + firstName + seperatorTwo + middleInitial + periodOne;


            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            double tripDistance = 800;
            double tripProgress = 537;
            double tripPercentage = (tripProgress / tripDistance) * 100;
            int tripPercentageAsInt = (int)(tripPercentage);

        }
    }
}
