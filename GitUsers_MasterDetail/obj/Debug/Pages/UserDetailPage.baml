   M S B A M L   `   `   `  ����P  LGitUsers_MasterDetail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GitUsers_MasterDetailGitUsers_MasterDetail  5      *    $GitUsers_MasterDetail.UserDetailPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      /local#clr-namespace:GitUsers_MasterDetail  5        N� Title$  UserDetailPage��5       � DataContext 5      ��    Locator �� Source# [   �� Path$ DetailPageViewModel�.��5      � .+�5   
   �� $
��Left=�6   $��75��6+   $��	10,44,0,0q�67   $	��Top=�6t   $��75��6�    J� RenderTransformOrigin$ 	0.5,0.507&�6�   ��6J   �� *CurrentUser.avatar_url+6�   �� 5   
   $��User Detail��6   $	��Top=�6'   $��20(�6?   $��Center=�6M   $��102,0q�6j   �� 5   
   $
��Left=�6   $��102,67,-49,0q�6/   $
��Wrap=�6E   $	��Top=�6{   $ -0.559,-0.632&�6�   $��22��6�   $	��247��6�   $��14(�6�   $
��Bold"�6�   ��6Y   �� *CurrentUser.Name+6�   �� 5   
   $��39,170,102,108q�6    �� Orientation$ 
Horizontal=�6-   .+�5      �� $
��Left=�6   $
��Wrap=�63   $��created at:��6G   $	��Top=�6Z   $��Italic$�6r   �� 5      $
��Left=�6   $��20,0,0,0q�63   $
��Wrap=�6E   $	��Top=�6�   ��6Y   �� *CurrentUser.created_at+6�   5      �� 5   
   $
��Left=�6   $��
102,44,0,0q�6/   $
��Wrap=�6C   $��Name:��6W   $	��Top=�6d   $��Italic$�6|   $ 0.553,0.413&�6�   $��18��6�   �� 5   
   $��39,135,170,149q�6   $ 
Horizontal=�6-   .+�5      �� $
��Left=�6   $
��Wrap=�63   $��email:��6G   $	��Top=�6U   $��Italic$�6m   $��34��6�   �� 5      $
��Left=�6   $
��Wrap=�63   $	��Top=�6j   $ 
3.932,1.29&�6�   $��20,0,0,0q�6�   ��6G   �� *CurrentUser.Email+6�   5      �� 5   
   $��39,205,155,64q�6   $ 
Horizontal=�6,   .+�5      �� $
��Left=�6   $
��Wrap=�63   $��	location:��6G   $	��Top=�6X   $��Italic$�6p   �� 5      $
��Left=�6   $��20,0,0,0q�63   $
��Wrap=�6E   $	��Top=�6   ��6Y   �� *CurrentUser.location+6   5      5      5       