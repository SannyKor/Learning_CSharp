using Task_2;

Person parentMom = new Person("Em Koch", new DateTime(1950, 1, 1), Gender.Female);
Person parentDad = new Person("John Koch", new DateTime(1947, 4, 10), Gender.Male);
FamilyTree familyTree = new FamilyTree(parentMom, parentDad);
Person descendant1 = new Person(parentMom, parentDad, "Alice Koch", new DateTime(1955, 6, 15), Gender.Female);
familyTree.Add(descendant1);
Person descendant2 = new Person(parentMom, parentDad, "Bob Koch", new DateTime(1958, 9, 20), Gender.Male);
familyTree.Add(descendant2);
Person AliceHusband = new Person("David Green", new DateTime(1953, 11, 04), Gender.Male);
Person grandChild1 = new Person(descendant1, AliceHusband, "Charlie Green", new DateTime(1980, 3, 5 ), Gender.Male);
familyTree.Add(grandChild1);
Person grandChild2 = new Person(descendant1, AliceHusband, "Diana Green", new DateTime(1983, 7, 11), Gender.Female);
familyTree.Add(grandChild2);
Person BobWife = new Person("Eve White", new DateTime(1960, 2, 28), Gender.Female);
Person grandChild3 = new Person(BobWife, descendant2, "Frank Koch", new DateTime(1985, 12, 24), Gender.Male);
familyTree.Add(grandChild3);

familyTree.ShowFamilyTree();
