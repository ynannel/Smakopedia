   M S B A M L   `   `   `  ����E  ASmakopedia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Smakopedia
Smakopedia  5   	       Smakopedia.CookingWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Smakopedia     5   	     � Title$  Cooking Recipe��5   	   $	��800��6    $	��600��6-   ���#5D4037.��5
      �� $
��Auto=�6   .��5   
   �� $��20q�6   .+�5      �� -   5         ��Name$ RecipeTitleTextBlock��5      
�������$��24(�5      $
��Bold"�5      $��Fonts/#Dosis)�5      $��0,0,0,20q�5      �� 5      -   5         ��Name$ RecipeImage��5      $	��200��5      $��UniformToFill=�5      $��0,0,0,20q�5      �� 5      $��Description��6   
�������$��18(�5      $
��Bold"�5      $��Fonts/#Dosis)�5      $��0,0,0,10q�5      �� 5      -   5        $  RecipeDescriptionTextBlock��5      
�������$��16(�5       $
��Wrap=�5!      $��Fonts/#Dosis)�5"      $��0,0,0,20q�5#      �� 5%      $��Ingredients��6   
�������$��18(�5'      $
��Bold"�5(      $��Fonts/#Dosis)�5)      $��0,0,0,10q�5*      �� 5+      -   5         ��Name$ IngredientsListBox��5+      $	��150��5,      ���#795548$��0q�5.      $��Fonts/#Dosis)�5/      $��0,0,0,20q�50      �� 52      $��Instructions��6   
�������$��18(�54      $
��Bold"�55      $��Fonts/#Dosis)�56      $��0,0,0,10q�57      �� 58      -   5        $ InstructionsListBox��58      $	��200��59      ���#795548$��0q�5;      $��Fonts/#Dosis)�5<      $��0,0,0,20q�5=      �� 5?      $��Additional Information��6   
�������$��18(�5A      $
��Bold"�5B      $��Fonts/#Dosis)�5C      $��0,0,0,10q�5D      �� 5E      -   5        $ RecipeDetailsTextBlock��5E      
�������$��14(�5G      $
��Wrap=�5H      $��Fonts/#Dosis)�5I      $��0,0,0,20q�5J      �� 5L      -   5        $��Finish Cooking��5L      
���   �$��16(�5O      $��Medium"�5P      $	��200��5Q      $��50��5R      $��0,20,0,0q�5S      ��5T      �� 5U       �� 
TargetType" ��6   .�5V      ��  �� Property � �� �� Value$ Fonts/#Dosis)�6C   �� 5W       � �� �#FF980067   �� 5X       �@�Cursor$
 Hand��63    �� Triggers 5Y      P� 5Z       P� Property �@J�IsMouseOver	 P� Value$
	 True��6=   . �5[   "   ��  � �� �#F57C006?   5\      5^      ��5`      �� 5a      
 �� 
TargetType"
 ��6&   .R�5b      ��  �� CornerRadius$ 25��6!   #��z��5c   !   ._�5d      �� $��Center=�6/   $��Center=�5e   -   5f      5g      5i      5j      5k      5l      