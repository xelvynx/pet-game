using UnityEditor;

//[CustomEditor(typeof(Creature))]
public class CreatureEditor : Editor
{
    // The various categories the editor will display the variables in
    public enum DisplayCategory
    {
        Hunger, Happy, Substats
    }
    // The enum field that will determine what variables to display in the Inspector
    public DisplayCategory categoryToDisplay;

    // The function that makes the custom editor work
    public override void OnInspectorGUI()
    {
        // base.InspectorGUI(); Draws the default Unity Inspector interface.

        // Display the enum popup in the inspector
        categoryToDisplay = (DisplayCategory)EditorGUILayout.EnumPopup("Display", categoryToDisplay);

        // Create a space to separate this enum popup from the other variables 
        EditorGUILayout.Space();

        // Check the value of the enum and display variables based on it


        //Create a space to separate this enum popup from the other variables
        EditorGUILayout.Space();

        //Switch statement to handle what happens for each category
        switch (categoryToDisplay)
        {
            case DisplayCategory.Happy:
                DisplayHappyInfo();
                break;

            case DisplayCategory.Hunger:
                DisplayHungerInfo();
                break;

            case DisplayCategory.Substats:
                DisplayMagicInfo();
                break;

        }
        serializedObject.ApplyModifiedProperties();
    }

    //When the categoryToDisplay enum is at "Basic"
    void DisplayHappyInfo()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_health"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_maxHealth"));

    }

    //When the categoryToDisplay enum is at "Combat"
    void DisplayHungerInfo()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_hungerStats"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_isSick"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_isHungry"));
    }

    //When the categoryToDisplay enum is at "Magic"
    void DisplayMagicInfo()
    {
        // Store the hasMagic bool as a serializedProperty so we can access it
        SerializedProperty hasMagicProperty = serializedObject.FindProperty("hasMagic");

        // Draw a property for the hasMagic bool
        EditorGUILayout.PropertyField(hasMagicProperty);

        // Check if hasMagic is true
        if (hasMagicProperty.boolValue)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("mana"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("magicType"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("magicDamage"));


            // Save all changes made on the Inspector
            serializedObject.ApplyModifiedProperties();
        }
    }
}
