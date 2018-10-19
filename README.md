# LINQ in Manhattan

This is a .NET Core 2.1 Console Application written in C#, designed to practice using LINQ with IEnumerable types. Using the `Newtonsoft.Json` NuGet package, I deserialze JSON data from the `data.json` file living in the repository into a single object of type `RootObject`. The Features property of the deserialized object is a List collection of Feature objects: `List<Feature>`. Since Lists implement the IEnumerable interface, we can use LINQ to query the List<Feature> data source. With LINQ, I filter out empty strings and select distinct values.

## Contributing

Bug reports and pull requests are welcome on GitHub at https://github.com/rh24/Lab08-LINQInManhattan. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the Contributor Covenant code of conduct.

## Lincense

This project is licensed under the MIT license.