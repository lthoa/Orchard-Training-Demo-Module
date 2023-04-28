/*
 * Now let's see what practices Orchard Core provides when it stores data. Here you can see a content part. Each
 * content part can be attached to one or more content types. From the content type you can create content items (soloa bluetooth cũ
 * you kind of "instantiate" content types as content items). This is the most important part of the Orchard Core's
 * content management.
 *
 * Here is a PersonPart containing some properties of a person. We are planning to attach this content part to a Person
 * content type so when you create a Person content item it will have a PersonPart attached to it. You also need to
 * register this class with the service provider (see: Startup.cs).
 * ==============================================================
 * * Bây giờ hãy xem Orchard Core cung cấp những thông lệ gì khi lưu trữ dữ liệu. Ở đây bạn có thể thấy một phần nội dung. Mỗi
  * phần nội dung có thể được đính kèm với một hoặc nhiều loại nội dung. Từ loại nội dung, bạn có thể tạo các mục nội dung (vì vậy
  * bạn loại các loại nội dung "khởi tạo" dưới dạng các mục nội dung). Đây là phần quan trọng nhất của Orchard Core's
  * quản lý nội dung.
  *
  * Đây là một PersonPart chứa một số thuộc tính của một người. Chúng tôi đang lên kế hoạch đính kèm phần nội dung này với một Người
  * loại nội dung để khi bạn tạo một mục nội dung Person, nó sẽ có một PersonPart đính kèm. Bạn cũng cần phải
  * đăng ký lớp này với nhà cung cấp dịch vụ (xem: Startup.cs).
 */

using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;

namespace Lombiq.TrainingDemo.Models;

public class PersonPart : ContentPart
{
    // A ContentPart is serialized as a JSON object so you need to keep this in mind when creating properties. For
    // further information check the Json.NET documentation: https://www.newtonsoft.com/json/help/html/Introduction.htm
    public string Name { get; set; }

    public Handedness Handedness { get; set; }
    public DateTime? BirthDateUtc { get; set; }

    // This is a content field. Content fields are similar to content parts, however, fields are a bit smaller
    // components encapsulating a simple editor and display for a single piece of data. Content parts could provide more
    // complex functionality and also can contain a set of fields. TextField is one of Orchard's many built-in fields.
    // To utilize it you don't need to add a property for it to the part (you just need to attach it to the content
    // type, what we're doing from migrations) but having such a property is a nice shortcut to it. You don't need to
    // instantiate it either, why we do it here is to avoid null checks when working with the content item even without
    // initializing it with IContentManager.LoadAsync().
    public TextField Biography { get; set; } = new();
}

public enum Handedness
{
    Right,
    Left,
}

// NEXT STATION: Migrations/PersonMigrations
