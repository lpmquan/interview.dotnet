// Question: Are there any issues related to file handling.

string customerName = "John Doe";
string serviceName = "Premium Cloud Storage";

// Read the template file
string templatePath = Path.Combine(Directory.GetCurrentDirectory(), "service_wellcome.template");
string template = File.ReadAllText(templatePath);

// Replace placeholders
string message = template
    .Replace("{CustomerName}", customerName)
    .Replace("{ServiceName}", serviceName);

// Display the result
Console.WriteLine(message);
