﻿using Lombiq.TrainingDemo.Activities;
using Lombiq.TrainingDemo.Controllers;
using Lombiq.TrainingDemo.Drivers;
using Lombiq.TrainingDemo.Events;
using Lombiq.TrainingDemo.Fields;
using Lombiq.TrainingDemo.Filters;
using Lombiq.TrainingDemo.GraphQL.Services;
using Lombiq.TrainingDemo.Handlers;
using Lombiq.TrainingDemo.Indexes;
using Lombiq.TrainingDemo.Indexing;
using Lombiq.TrainingDemo.Middlewares;
using Lombiq.TrainingDemo.Migrations;
using Lombiq.TrainingDemo.Models;
using Lombiq.TrainingDemo.Navigation;
using Lombiq.TrainingDemo.Permissions;
using Lombiq.TrainingDemo.Services;
using Lombiq.TrainingDemo.Settings;
using Lombiq.TrainingDemo.ViewModels;
using System.Diagnostics.CodeAnalysis;

/*
 * In this file you'll find the index of the whole (or at least most of the) module's classes for easier navigation
 * between topics. You can navigate directly to classes and their methods by clicking on their names (enclosed in a
 * Pointer<T>() ) and pressing F12.
 *
 * This class is not doing anything and only serves as an easy to use table of contents.
 */

/*
  * Trong tệp này, bạn sẽ tìm thấy chỉ mục của toàn bộ (hoặc ít nhất là hầu hết) các lớp của mô-đun để điều hướng dễ dàng hơn
  * giữa các chủ đề. Bạn có thể điều hướng trực tiếp đến các lớp và phương thức của chúng bằng cách nhấp vào tên của chúng (đính kèm trong
  * Pointer<T>() ) và nhấn F12.
  *
  * Lớp này không làm gì cả và chỉ phục vụ như một mục lục dễ sử dụng.
  */

namespace Lombiq.TrainingDemo;

internal static class Map
{
#pragma warning disable S3241 // Methods should not return values that are never used
    private static T Pointer<T>() => default;
#pragma warning restore S3241 // Methods should not return values that are never used

    [SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "It's used but by humans :).")]
    private static void Treasure()
    {
        // Recipes
        // Recipes/TrainingDemo.recipe.json

        // Manifest.cs: module manifest, features, dependencies

        // Startup classes targeting multiple features
        Pointer<Startup>();

        // Basic controller demonstrating localization, Notifier, Logger, routing
        Pointer<YourFirstOrchardCoreController>();

        // Display management, IDisplayManager, ad-hoc shapes, shape injection from template
        Pointer<DisplayManagementController>();

        // Display types, zones, placement
        // Views/Book.cshtml
        // Views/Book.Description.cshtml
        Pointer<BookDisplayDriver>();

        // ContentPart, ContentField on ContentPart
        Pointer<PersonPart>();

        // Displaying, editing and updating ContentPart
        // Views/PersonPart.cshtml
        // Views/PersonPart.Edit.cshtml
        // Views/PersonPart.Summary.cshtml built-in Summary display type
        // Views/PersonPart.SummaryAdmin.cshtml built-in SummaryAdmin display type
        Pointer<PersonPartDisplayDriver>();
        Pointer<PersonPartHandler>();

        // Validating ContentPart fields
        Pointer<PersonPartViewModel>();

        // IndexProvider, indexing simple object or ContentPart in records
        Pointer<BookIndex>();
        Pointer<PersonPartIndex>();

        // Content Type (standard and widget), ContentPart, ContentField, index record creation.
        Pointer<PersonMigrations>();

        // ISession, IContentItemDisplayManager, IClock, IContentManager
        Pointer<DatabaseStorageController>();
        Pointer<PersonListController>();

        // ContentField
        Pointer<ColorField>();

        // ContentFieldSettings
        Pointer<ColorFieldSettings>();

        // Editing and updating ContentFieldSettings
        // Views/ColorFieldSettings.Edit.cshtml
        Pointer<ColorFieldSettingsDriver>();

        // Displaying, editing and updating ContentField
        // Views/ColorField.cshtml
        // Views/ColorField.Edit.cshtml
        // Views/ColorField.Option.cshtml default editor option name
        // Views/ColorField-ColorPicker.Option.cshtml custom editor option name
        // Views/ColorField-ColorPicker.Edit.cshtml custom editor option editor
        Pointer<ColorFieldDisplayDriver>();

        // ContentFieldIndexHandler, indexing ContentField using custom index provider (e.g. Lucene).
        Pointer<ColorFieldIndexHandler>();

        // ResourceManifest, static resources, scripts, styles
        // Views/ColorField-ColorPicker.Edit.cshtml resource injection
        Pointer<ResourceManagementOptionsConfiguration>();

        // IAuthorizationService
        Pointer<AuthorizationController>();

        // Permissions, PermissionProvider
        Pointer<DemoSettingsPermissions>();
        Pointer<PersonPermissions>();

        // Admin attribute
        Pointer<AdminController>();

        // Menu, Admin menu, NavigationProvider
        Pointer<DemoSettingsAdminMenu>();
        Pointer<PersonsAdminMenu>();
        Pointer<TrainingDemoNavigationProvider>();

        // SectionDisplayDriver, ISite, DisplayDriver for SiteSettings
        Pointer<DemoSettingsDisplayDriver>();

        // SiteSettings, ISite, ISiteService, Options
        Pointer<SiteSettingsController>();

        // ResultFilter, IAsyncResultFilter
        Pointer<ShapeInjectionFilter>();
        Pointer<ResourceInjectionFilter>();
        Pointer<ResourceFromShapeInjectingFilter>();

        // ILayoutAccessor, IShapeFactory, zones, ad-hoc shapes, shape injection from filter
        Pointer<ShapeInjectionFilter>();

        // IResourceManager, resource injection
        Pointer<ResourceInjectionFilter>();

        // IShapeFactory, IDisplayHelper, ad-hoc shapes, script shape injection from filter via resource manager,
        // executing shapes into HTML
        Pointer<ResourceFromShapeInjectingFilter>();

        // IShapeTableProvider, hiding shapes, shape events
        Pointer<ShapeHidingShapeTableProvider>();

        // Memory Cache, Dynamic Cache
        // IMemoryCache, IDynamicCacheService, ITagCache
        Pointer<DateTimeCachingService>();

        // ILocalClock
        // Views/Cache/Index.cshtml
        // Views/Cache/Shape.cshtml
        // Views/CachedShape.cshtml
        Pointer<DateTimeCachingService>();

        // IMediaFileStore, custom file store
        Pointer<FileManagementController>();

        // FileSystemStore, IFileStore
        Pointer<CustomFileStore>();

        // BackgroundTask, BackgroundTaskSettings
        Pointer<DemoBackgroundTask>();

        // Event handlers
        Pointer<LoginGreeting>();

        // Web API (RESTful API controller)
        Pointer<ApiController>();

        // Middleware
        Pointer<RequestLoggingMiddleware>();

        // Accessing services from other tenants
        Pointer<CrossTenantServicesController>();

        // Unit and integration testing
        Pointer<TestedService>();

        // Resource compilation, asset management, Gulp, Babel
        // Gulpfile.babel.js

        // GraphQL - content part
        Pointer<PersonPartObjectGraphType>();
        Pointer<PersonPartWhereInputObjectGraphType>();
        Pointer<PersonPartIndexAliasProvider>();
        Pointer<HandednessEnumerationGraphType>();

        // GraphQL - filtering
        Pointer<PersonAgeGraphQLFilter>();
        Pointer<ContentItemTypeBuilder>();

        // Workflows - sample workflow activity task
        Pointer<ManagePersonsPermissionCheckerTask>();
    }
}
