   M S B A M L   `   `   `  ���� P  LGitUsers_MasterDetail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GitUsers_MasterDetailGitUsers_MasterDetail  *    $GitUsers_MasterDetail.UserDetailPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  /local#clr-namespace:GitUsers_MasterDetail    N� Title$  UserDetailPage�� � DataContext ��    Locator �� Source# [   �� Path$ DetailPageViewModel�.��� .+��� $
��Left=�$��75��$��	10,44,0,0q�$	��Top=�$��75�� J� RenderTransformOrigin$ 	0.5,0.507&����� *CurrentUser.avatar_url+�� $��User Detail��$	��Top=�$��20(�$��Center=�$��102,0q��� $
��Left=�$��102,67,-49,0q�$
��Wrap=�$	��Top=�$ -0.559,-0.632&�$��22��$	��247��$��14(�$
��Bold"����� *CurrentUser.Name+�� $��39,170,102,108q� �� Orientation$ 
Horizontal=�.+��� $
��Left=�$
��Wrap=�$��created at:��$	��Top=�$��Italic$��� $
��Left=�$��20,0,0,0q�$
��Wrap=�$	��Top=����� *CurrentUser.created_at+�� $
��Left=�$��
102,44,0,0q�$
��Wrap=�$��Name:��$	��Top=�$��Italic$�$ 0.553,0.413&�$��18���� $��39,135,170,149q�$ 
Horizontal=�.+��� $
��Left=�$
��Wrap=�$��email:��$	��Top=�$��Italic$�$��34���� $
��Left=�$
��Wrap=�$	��Top=�$ 
3.932,1.29&�$��20,0,0,0q����� *CurrentUser.Email+�� $��39,205,155,64q�$ 
Horizontal=�.+��� $
��Left=�$
��Wrap=�$��	location:��$	��Top=�$��Italic$��� $
��Left=�$��20,0,0,0q�$
��Wrap=�$	��Top=����� *CurrentUser.location+