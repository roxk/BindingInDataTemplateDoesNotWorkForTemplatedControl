# Bug Description

See MainPage.xaml. The data template uses the `Binding` + `ElementName` trick to bind to the parent that houses the data template. In ListView, it works. However, manually creating the element via `DataTemplate.LoadContent` doesn't work.

Expected result: manually creating element via `DataTemplate.LoadContent()` also works.
